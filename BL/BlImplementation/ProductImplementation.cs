using BlApi;
using static BO.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product item)
        {
            try
            {
                return _dal.product.Create(item.ConvertBOproductToDOproduct());
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.product.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public void GetSalesToProduct(BO.ProductInOrder product, bool isPreferred)
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

        public BO.Product? Read(int id)
        {
            try
            {
                DO.Product doRes = _dal.product.Read(id);
                return doRes.ConvertDOproductToBOproduct();
            }
            catch (Exception e) 
            {
                return null;
            }
        }

        public BO.Product? Read(Func<BO.Product, bool>? filter)
        {
            try
            {
                DO.Product product = _dal.product.Read(c => filter(c.ConvertDOproductToBOproduct()));
                return product.ConvertDOproductToBOproduct();
            }
            catch
            {
                return null;
            }

        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            if (filter == null)
               
                
                return _dal.product.ReadAll().Select(p=>p.ConvertDOproductToBOproduct()).ToList();
            return _dal.product.ReadAll(p => filter(p.ConvertDOproductToBOproduct())).Select(p=> p.ConvertDOproductToBOproduct()).ToList();
        }

        public void Update(BO.Product item)
        {
            try
            {
                _dal.product.Update(item.ConvertBOproductToDOproduct());
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
