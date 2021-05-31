using System;
using System.Collections.Generic;
using System.Text;

namespace _33_Sobreposicao_Override_Virtual_Base
{
    sealed class SavingsAccount : Account //colocando o sealed a SavingsAccount não pode ser herdada
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) //colocando o sealed ela não pode ser sobreescrita novamente
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
