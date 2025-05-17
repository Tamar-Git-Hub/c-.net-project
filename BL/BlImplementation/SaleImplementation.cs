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
    internal class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Sale item)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Sale");
                return _dal.sale.Create(item.ConvertBOsaleToDOsale());

            }
            catch (Exception ex)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Sale Exeption: {ex.Message}");
                throw new Exception();
            }
        }

        public void Delete(int id)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Sale");
                _dal.sale.Delete(id);
            }
            catch (Exception ex)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Sale Exepion: {ex.Message}");
                throw new Exception();
            }
        }

        public BO.Sale? Read(int id)
        {

            try
            {
                DO.Sale doRes = _dal.sale.Read(id);
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {id} Sale");
                return doRes.ConvertDOsaleToBOsale();
            }
            catch
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {null} Sale");
                return null;
            }
        }

        public BO.Sale? Read(Func<BO.Sale, bool>? filter)
        {
            try
            {
                DO.Sale sale = _dal.sale.Read(s=> filter(s.ConvertDOsaleToBOsale()));
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {sale} Sale");
                return sale.ConvertDOsaleToBOsale();
            }
            catch
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {null} Sale");
                return null;
            }
        }

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            if (filter == null)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll Sale");
                return _dal.sale.ReadAll().Select(s => s.ConvertDOsaleToBOsale()).ToList();
            }
            return _dal.sale.ReadAll(s => filter(s.ConvertDOsaleToBOsale())).Select(s => s.ConvertDOsaleToBOsale()).ToList();
        }

        public void Update(BO.Sale item)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Sale");
                _dal.sale.Update(item.ConvertBOsaleToDOsale());
            }
            catch (Exception ex)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Sale Exeption: {ex.Message}");
                throw new Exception();
            }
        }
    }
}
