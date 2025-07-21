using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class LongTermLoan : ILoan
    {
        public string Name { get; }
        public string Type => "Long Term Loan";
        public double Balance { get; set; }

        private double monthlyPayment = 200;
        private double interestRate = 0.05;

        public LongTermLoan(string name, double balance)
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
