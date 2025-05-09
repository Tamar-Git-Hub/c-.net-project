using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface IDal
    {
        IcustomerAble customer { get; }
        IsaleAble sale { get; }
        IproductAble product { get; }   
    }
}
