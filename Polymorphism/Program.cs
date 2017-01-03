using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserError> errors = new List<UserError>();
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());

            foreach (var error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
