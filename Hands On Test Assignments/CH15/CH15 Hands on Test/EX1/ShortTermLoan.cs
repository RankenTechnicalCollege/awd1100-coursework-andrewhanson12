using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class ShortTermLoan : ILoan
    {
        public string Name { get; }
        public string Type => "Short Term Loan";
        public double Balance { get; set; }

        private double monthlyPayment = 450;
        private double interestRate = 0.10;

        public ShortTermLoan(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
        public void MakePayment()
        {
            Balance -= monthlyPayment;
        }
        public void ApplyInterest()
        {
            Balance += Balance * interestRate;
        }
    }
}
