using System;

// regions definieren, om dingen makkelijker te organiseren ctrl + a +s

namespace Banking.Models.Domain
{
    // normaal leeg, betekent internal -> enkel binnen de assembly
    // members (fields, properties...) hebben automatisch private als setting
    public class BankAccount
    {
        #region Fields
        // attributen aangetoond door te beginnen met een underscore
        // private string _accountNumber;
        private decimal _balance;

        // constante aanmaken
        // M is om te bewijzen dat het een decimal is en niet een double
        // const is altijd static, enkel via de klasse beschikbaar
        ////////public const decimal WithdrawCost = 0.10M;
        #endregion

        #region properties

        //// getter en setter worden in c# niet gebruikt
        //public decimal GetBalance()
        //{
        //    return _balance;
        //}

        //private void SetBalance(decimal value)
        //{
        //    _balance = value;
        //}

        // property aanmaken voor balance
        // dit zijn automatic properties = pure get en set
        // als er niks voor get of set staat, zijn ze automatisch public
        // geen attribuut vanboven nodig

        ////////public decimal Balance { get; private set; }

        // full property -> zelf een backing field definieren
        //  eerst een attribuut balance maken
        public decimal Balance
        {
            get { return _balance; }
            private set
            {
                // setter krijgt automatisch een parameter value
                if (value < 0)
                    throw new ArgumentException("No negative balance allowed");
                _balance = value;
            }
        }

        // prop -> automatic property maken// dubbel tab indrukken
        public string AccountNumber { get; private set; }

        #endregion

        #region Constructors

        public BankAccount()
        {

        }
        // shortcut constructor ctor
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        // referentie naar andere constructor na parameter lijst
        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
             //gebruik maken van de getter
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount /* + WithdrawCost */;
        }

        // optionele parameter
        // optionele parameter is altijd de laatste parameter
        //public void Deposit(decimal amount, int nrOfTimes = 1)
        //{
        //    // gebruik maken van de getter
        //    Balance += amount * nrOfTimes;
        //}
        #endregion
    }
}


/* team explorer
 * groene stekker is om een clone te maken
 * klik op home
 * bekijk changes
 * nu 2 verschillende groepen
 * dubbel klikken op klasse toont de aanpassingen
 *  
 * /
