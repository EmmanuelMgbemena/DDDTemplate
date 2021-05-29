﻿using FXBLOOM.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FXBLOOM.DomainLayer.CustomerAggregate
{
    public class Account:ValueObject<Account>
    {
        public string AccountNumber { get; private set; }
        public string BankName { get; private set; }

        internal static Account GetAccount(string number, string bankName)
        {
            Account account = new Account();
            account.AccountNumber = number;
            account.BankName = bankName;

            return account;
        }
    }
}
