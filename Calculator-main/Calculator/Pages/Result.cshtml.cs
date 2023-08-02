using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace Calculator.Pages
{
    public class ResultModel : PageModel
    {
        public string FirstNumber { get; set; } = string.Empty;

        public string SecondNumber { get; set; } = string.Empty;

        public string Operation { get; set; } = string.Empty;

        public string Result { get; set; } = string.Empty;

        public List<string> Line { get; set; } = new();

        public void OnGet(string firstNumber, string secondNumber, string operation)
        {
            if (string.IsNullOrEmpty(firstNumber) || !long.TryParse(firstNumber, out _))
            {
                throw new ArgumentException("Invalid firstNumber");
            }

            if (string.IsNullOrEmpty(secondNumber) || !long.TryParse(secondNumber, out _))
            {
                throw new ArgumentException("Invalid secondNumber");
            }

            if (string.IsNullOrEmpty(operation) || (operation != "addition" && operation != "subtraction"))
            {
                throw new ArgumentException("Invalid operation");
            }

            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Operation = operation;
            Proceed();
        }
        
        private void Proceed()
        {
            switch (Operation)
            {
                case "addition":
                    Addition();
                    break;
                case "subtraction":
                    Subtraction();
                    break;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
        private void Addition()
        {
            if (SecondNumber.Length > FirstNumber.Length)
            {
                (FirstNumber, SecondNumber) = (SecondNumber, FirstNumber);
            }

            if (Result.Length == 0)
            {
                Result = "0";
            }

            if (long.TryParse(FirstNumber, out long num1) && long.TryParse(SecondNumber, out long num2))
            {
                try
                {
                    checked
                    {
                        long result = num1 + num2;
                        Result = result.ToString();
                    }
                }
                catch (OverflowException)
                {
                    Result = "Overflow";
                }
            }
            else
            {
                Result = "Invalid numbers";
            }
        }

        
        private void Subtraction()
        {

            if(Result.Length == 0) 
            {
                Result = "0";
            }

            long result = long.Parse(FirstNumber) - long.Parse(SecondNumber);
            Result = result.ToString();
            if (SecondNumber.Length > FirstNumber.Length)
            {
                (FirstNumber, SecondNumber) = (SecondNumber, FirstNumber);
                //Result = $"-{Result}";
            }

        }
    }
}


