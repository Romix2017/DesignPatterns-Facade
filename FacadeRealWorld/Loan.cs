﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeRealWorld
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}
