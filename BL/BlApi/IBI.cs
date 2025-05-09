using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IBI
    {
        public ICustomer customer { get;  }
        public IOrder order { get; }
        public IProduct product { get; }
        public ISale sale { get;  }

    }
}
