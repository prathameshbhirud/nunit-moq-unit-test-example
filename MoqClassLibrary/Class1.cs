using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqClassLibrary
{
    public class Class1
    {
    }

    public class CheckEmployee
    {
        public virtual Boolean checkEmp()
        {
            throw new NotImplementedException();
        }
    }
    public class ProcessEmployee
    {
        public Boolean insertEmployee(CheckEmployee objTmp)
        {
            objTmp.checkEmp();
            return true;
        }
    }
}
