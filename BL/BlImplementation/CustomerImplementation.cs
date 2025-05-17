using BlApi;
using static BO.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using static BO.Exceptions;
using System.Reflection;

namespace BlImplementation
{
    internal class CustomerImplementation : ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
       // public bool IsCustomerExist { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Create(BO.Customer item)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Customer");
                return _dal.customer.Create(item.ConvertBOcustomerToDOcustomer());
            }
            catch (Exception ex)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Customer  Exception: {ex.Message}  ");
                throw new BLIdNotFoundException("id exist");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.customer.Delete(id);
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Customer");

            }
            catch (Exception ex)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Customer  Exception {ex.Message}");

                throw new Exception();

            }
        }

        public BO.Customer? Read(int id)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read Customer");
                DO.Customer doRes=_dal.customer.Read(id);
                return doRes.ConvertDOcustomerToBOcustomer();
            }
            catch
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read Customer   null");
                return null;
            }
        }

        public BO.Customer? Read(Func<BO.Customer, bool>? filter)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read Customer");
                DO.Customer customer = _dal.customer.Read(c => filter(c.ConvertDOcustomerToBOcustomer()));
                return customer.ConvertDOcustomerToBOcustomer();
            }
            catch
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read Customer  NULL");
                return null;

            }
                
        }

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            if (filter == null)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read All Customer");
                return _dal.customer.ReadAll().Select(c => c.ConvertDOcustomerToBOcustomer()).ToList();

            }
           
            return  _dal.customer.ReadAll(c => filter(c.ConvertDOcustomerToBOcustomer())).Select(c=>c.ConvertDOcustomerToBOcustomer()).ToList();
        }

        public void Update(BO.Customer item)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Customer");
                _dal.customer.Update(item.ConvertBOcustomerToDOcustomer());
            }
            catch( Exception ex) 
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Customer   Exception {ex.Message} ");
                throw new Exception();
            }
        }

       public bool IsCustomerExist(int customerId)
        {
            Customer c =_dal.customer.Read(customerId);
            return c != null;
        }
    }
}
