using BlApi;
using static BO.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Sale item)
        {
            try
            {
                return _dal.sale.Create(item.ConvertBOsaleToDOsale());
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
                _dal.sale.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public BO.Sale? Read(int id)
        {

            try
            {
                DO.Sale doRes = _dal.sale.Read(id);
                return doRes.ConvertDOsaleToBOsale();
            }
            catch
            {
                return null;
            }
        }

        public BO.Sale? Read(Func<BO.Sale, bool>? filter)
        {
            try
            {
                DO.Sale sale = _dal.sale.Read(s=> filter(s.ConvertDOsaleToBOsale()));
                return sale.ConvertDOsaleToBOsale();
            }
            catch
            {
                return null;
            }
        }

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            if (filter == null)
                return _dal.sale.ReadAll().Select(s => s.ConvertDOsaleToBOsale()).ToList();
            return _dal.sale.ReadAll(s => filter(s.ConvertDOsaleToBOsale())).Select(s => s.ConvertDOsaleToBOsale()).ToList();
        }

        public void Update(BO.Sale item)
        {
            try
            {
                _dal.sale.Update(item.ConvertBOsaleToDOsale());
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
