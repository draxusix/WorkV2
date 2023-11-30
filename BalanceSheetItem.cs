﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadaniV2
{
    public class BalanceSheetItem
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public ItemType Type { get; set; }
        public ICurrencyConversionStrategy ConversionStrategy { get; set; }

        public decimal GetAmountInEUR()
        {
            return ConversionStrategy.ConvertToEUR(Amount);
        }

    }
}
