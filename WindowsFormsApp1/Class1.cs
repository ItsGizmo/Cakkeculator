using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    namespace Alpha
    {
        namespace Beta
        {
            namespace Charlie

            {
            }
        }
    }
    class Class1
    {
        // char                     'c'                     single character
        // string - string          'string of characters'  String of characters 
        // int - integer            234                     whole digit number, up to about 32 characters
        // float                    23.344                  decimal place number, limited percision
        // double                   444.55959555            decimal place number, double percision
        // decimal                  234234.23423423423      decimal place number, largest possible decimal place precision

        public float Addition(float left, float right)
        {
            return left + right;
        }
        
        public float Subtraction(float left, float right)
        {
            return left - right;
        }
        public float Division(float left, float right)
        {
            return left / right;
        }
        public float Multiplication(float left, float right)
        {
            return left * right;
        }
    }
}
