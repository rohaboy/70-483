using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace exceptionDispatchInfo
{
    class Program
    {
        static ExceptionDispatchInfo possibleException = null; 
        static void Main(string[] args)
        {
            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }


            if(possibleException !=null)
            {
                possibleException.Throw();
            }
        }
    }
}
