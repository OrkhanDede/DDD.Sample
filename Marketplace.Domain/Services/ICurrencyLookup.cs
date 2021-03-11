using System;
using System.Collections.Generic;
using System.Text;
using Marketplace.Domain.ValueObjects;
using Marketplace.Framework;

namespace Marketplace.Domain.Services
{
    public interface ICurrencyLookup
    {
        Currency FindCurrency(string currencyCode);
    }
   
}
