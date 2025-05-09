using BlApi;
using static BO.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

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
                return _dal.customer.Create(item.ConvertBOcustomerToDOcustomer());
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
                _dal.customer.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public BO.Customer? Read(int id)
        {
            try
            {
                DO.Customer doRes=_dal.customer.Read(id);
                return doRes.ConvertDOcustomerToBOcustomer();
            }
            catch
            {
                return null;
            }
        }

        public BO.Customer? Read(Func<BO.Customer, bool>? filter)
        {
            try
            {
                DO.Customer customer = _dal.customer.Read(c => filter(c.ConvertDOcustomerToBOcustomer()));
                return customer.ConvertDOcustomerToBOcustomer();
            }
            catch
            {
                return null;
            }
                
        }

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            if (filter == null)
                return _dal.customer.ReadAll().Select(c=>c.ConvertDOcustomerToBOcustomer()).ToList();
            return  _dal.customer.ReadAll(c => filter(c.ConvertDOcustomerToBOcustomer())).Select(c=>c.ConvertDOcustomerToBOcustomer()).ToList();
        }

        public void Update(BO.Customer item)
        {
            try
            {
                _dal.customer.Update(item.ConvertBOcustomerToDOcustomer());
            }
            catch( Exception ex) 
            {
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
