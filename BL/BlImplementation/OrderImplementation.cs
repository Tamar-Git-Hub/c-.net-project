using BlApi;
using static BO.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;


namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int amount)
        {
            var product = _dal.product.Read(productId);
            if (product == null)
            {
                throw new Exception("המוצר לא נמצא");
            }
            var existingProductInOrder = order.ProductsInOrder.FirstOrDefault(p => p.Id == productId);
            if (existingProductInOrder != null)
            {
                if (existingProductInOrder.Amount + amount > product.AmountInStock)
                {
                    throw new Exception("אין מספיק במלאי");
                }
                existingProductInOrder.Amount += amount;
            }
            else
            {
                if (amount > product.AmountInStock)
                {
                    throw new Exception("אין מספיק במלאי");
                }
                var newProductInOrder = new BO.ProductInOrder
                {
                    Id = product.Id,
                    Amount = amount,
                    Price = product.Price
                };
                order.ProductsInOrder.Add(newProductInOrder);
                existingProductInOrder = newProductInOrder; // לעדכן למוצר החדש לוגית
            }
            SearchSaleForProduct(existingProductInOrder, false);
            CalcTotalPriceForProduct(existingProductInOrder);
            CalcTotalPrice(order);
            return existingProductInOrder.Sales;
        }

        public void CalcTotalPrice(BO.Order order)
        {
            order.TotalPrice += (from product in order.ProductsInOrder
                                 select product.Price).Sum();
        }

        public void CalcTotalPriceForProduct(BO.ProductInOrder productForCalc)
        {
            int count = productForCalc.Amount;
            List<SaleInProduct> saleInProducts = new List<SaleInProduct>();
            var sales = productForCalc.Sales
                .Where(sale => sale.Amount >= count)
                .Select(sale =>
                {
                    double sum = count / sale.Amount * sale.Price;
                    count -= (int)(count / sale.Amount);
                    saleInProducts.Add(sale);
                    return new { sale, sum };
                })
                .TakeWhile(x => count > 0)
                .ToList();
            double total = sales.Sum(x => x.sum) + (count * productForCalc.Price);
            productForCalc.TotalPrice = total;
            productForCalc.Sales = sales.Select(x => x.sale).ToList();
        }

        public void DoOrder(BO.Order order)
        {

            try
            {
                int cnt = order.ProductsInOrder
                           .Sum(p => p.Amount);
                var update = order.ProductsInOrder.Select(p => { var x = _dal.product.Read(p.Id); if (x.AmountInStock < p.Amount) throw new Exception("אין מספיק במלאי מהמוצר"); return x with { AmountInStock = x.AmountInStock - p.Amount }; }).ToList();
                foreach ( var x in update)
                {
                    _dal.product.Update(x);
                }
                
            }
            catch
            {

            }
        }

        public void SearchSaleForProduct(BO.ProductInOrder product, bool isPreferred)
        {
            try
            {
                product.Sales = _dal.sale.ReadAll(s => s.ProductId == product.Id
                && s.StartSaleDate <= DateTime.Now && s.EndSaleDate >= DateTime.Now
                && product.Amount >= s.MinAmount
                && (isPreferred || s.Club))
                    .Select(s => new BO.SaleInProduct() { Id = s.codeIndex, Amount = s.MinAmount, IsIntendedForAll = s.Club, Price = s.Price })
                    .OrderBy(s => s.Price)
                    .ToList();
            }
            catch (Exception ex)
            {


            }
        }
    }
}
