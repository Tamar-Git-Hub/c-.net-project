using DalApi;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalList : IDal
    {
        private DalList() { }
        private static readonly DalList instance = new DalList();
        public static DalList Instance
        {
            get { return instance; }
        }



        public IsaleAble sale => new SaleImplementation();
        public IcustomerAble customer => new CustomerImplementation();
        public IproductAble product => new ProductImplementation();
    }
}
