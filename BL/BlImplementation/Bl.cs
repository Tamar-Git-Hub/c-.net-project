using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class Bl : IBI
    {
        public ICustomer customer => new CustomerImplementation();

        public IOrder order => new OrderImplementation();

        public IProduct product => new ProductImplementation();

        public ISale sale =>new SaleImplementation();
    }
}
