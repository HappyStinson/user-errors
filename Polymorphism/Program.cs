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

            Console.WriteLine("Try with incorrect data\n");

            NumericInputAsString(errors, "five");
            TextInputAsInt(errors, 5);
            LowerCaseInputAsUpperCase(errors, "LOWER");
            UpperCaseInputAsLowerCase(errors, "upper");
            DateInputAsDateTime(errors, DateTime.Today);

            if (errors.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Found error in input!\n");

                foreach (var error in errors)
                {
                    Console.WriteLine(error.UEMessage());
                }

                errors.Clear();
            }            

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Try with correct data\n");

            NumericInputAsInt(errors, 5);
            TextInputAsString(errors, "five");
            LowerCaseInputAsLowerCase(errors, "lower");
            UpperCaseInputAsUpperCase(errors, "UPPER");            
            DateInputAsDate(errors, new Date("2017-01-03"));

            if (errors.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Found error in input!\n");

                foreach (var error in errors)
                {
                    Console.WriteLine(error.UEMessage());
                }
            }
        }

        private static void DateInputAsDateTime(List<UserError> errors, DateTime dateTimeInput)
        {
            Console.WriteLine($"Date input: {dateTimeInput}");
            Type t5 = dateTimeInput.GetType();
            if (!t5.Equals(typeof(Date)))
                errors.Add(new DateInputError());
        }

        private static void DateInputAsDate(List<UserError> errors, Date dateInput)
        {
            Console.WriteLine($"Date input: {dateInput}");
            Type t5 = dateInput.GetType();
            if (!t5.Equals(typeof(Date)))
                errors.Add(new DateInputError());
        }

        private static void UpperCaseInputAsLowerCase(List<UserError> errors, string lowerCaseInput)
        {
            Console.WriteLine($"Uppercase input: {lowerCaseInput}");
            Type t4 = lowerCaseInput.GetType();
            if (!t4.Equals(typeof(string)))
                errors.Add(new TextInputError());
            else
            {
                var expected = lowerCaseInput.ToUpperInvariant();
                if (expected != lowerCaseInput)
                    errors.Add(new UpperCaseInputError());
            }
        }

        private static void UpperCaseInputAsUpperCase(List<UserError> errors, string upperCaseInput)
        {
            Console.WriteLine($"Uppercase input: {upperCaseInput}");
            Type t4 = upperCaseInput.GetType();
            if (!t4.Equals(typeof(string)))
                errors.Add(new TextInputError());
            else
            {
                var expected = upperCaseInput.ToUpperInvariant();
                if (expected != upperCaseInput)
                    errors.Add(new UpperCaseInputError());
            }
        }

        private static void LowerCaseInputAsUpperCase(List<UserError> errors, string upperCaseInput)
        {
            Console.WriteLine($"Lowercase input: {upperCaseInput}");
            Type t3 = upperCaseInput.GetType();
            if (!t3.Equals(typeof(string)))
                errors.Add(new TextInputError());
            else
            {
                var expected = upperCaseInput.ToLowerInvariant();
                if (expected != upperCaseInput)
                    errors.Add(new LowerCaseInputError());
            }
        }

        private static void LowerCaseInputAsLowerCase(List<UserError> errors, string lowerCaseInput)
        {
            Console.WriteLine($"Lowercase input: {lowerCaseInput}");
            Type t3 = lowerCaseInput.GetType();
            if (!t3.Equals(typeof(string)))
                errors.Add(new TextInputError());
            else
            {
                var expected = lowerCaseInput.ToLowerInvariant();
                if (expected != lowerCaseInput)
                    errors.Add(new LowerCaseInputError());
            }
        }

        private static void TextInputAsInt(List<UserError> errors, int textInput)
        {
            Console.WriteLine($"Text input: {textInput}");
            Type t2 = textInput.GetType();
            if (!t2.Equals(typeof(string)))
                errors.Add(new TextInputError());
        }

        private static void TextInputAsString(List<UserError> errors, string textInput)
        {
            Console.WriteLine($"Text input: {textInput}");
            Type t2 = textInput.GetType();
            if (!t2.Equals(typeof(string)))
                errors.Add(new TextInputError());
        }

        private static void NumericInputAsString(List<UserError> errors, string numericInput)
        {
            Console.WriteLine($"Numeric input: {numericInput}");
            Type t = numericInput.GetType();
            if (!t.Equals(typeof(int)))
                errors.Add(new NumericInputError());
        }

        private static void NumericInputAsInt(List<UserError> errors, int numericInput)
        {
            Console.WriteLine($"Numeric input: {numericInput}");
            Type t = numericInput.GetType();
            if (!t.Equals(typeof(int)))
                errors.Add(new NumericInputError());
        }
    }
}
