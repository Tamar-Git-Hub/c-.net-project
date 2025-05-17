using BlApi;
using static BO.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BlImplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product item)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Product");
                return _dal.product.Create(item.ConvertBOproductToDOproduct());
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" {item} was added");
            }
            catch (Exception ex)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Product   Exception: {ex.Message}");
                throw new Exception();
            }
        }

        public void Delete(int id)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Product");
                _dal.product.Delete(id);
            }
            catch (Exception ex)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Product  Exception: {ex.Message}");
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
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {id} Product");
                DO.Product doRes = _dal.product.Read(id);
                return doRes.ConvertDOproductToBOproduct();
            }
            catch (Exception e) 
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {id} Product  null");
                return null;
            }
        }

        public BO.Product? Read(Func<BO.Product, bool>? filter)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read Product");
                DO.Product product = _dal.product.Read(c => filter(c.ConvertDOproductToBOproduct()));
                return product.ConvertDOproductToBOproduct();
            }
            catch
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read Product  null");
                return null;
            }

        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            if (filter == null)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"ReadAll Product");
                return _dal.product.ReadAll().Select(p => p.ConvertDOproductToBOproduct()).ToList();
            }
            return _dal.product.ReadAll(p => filter(p.ConvertDOproductToBOproduct())).Select(p=> p.ConvertDOproductToBOproduct()).ToList();
        }

        public void Update(BO.Product item)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Product");
                _dal.product.Update(item.ConvertBOproductToDOproduct());
            }
            catch (Exception ex)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Product  Exeption: {ex.Message}");
                throw new Exception();
            }
        }
    }
}
