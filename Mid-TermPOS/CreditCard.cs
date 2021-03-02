using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_TermPOS
{
    class CreditCard
    {
        class CreditCard
        {
            public string CardNumber { get; }
            public string ExpMonth { get; }
            public string ExpYear { get; }
            public string CVV { get; }

            public CreditCard(string cn, string em, string ey, string cvv)
            {
                CardNumber = cn;
                ExpMonth = em;
                ExpYear = ey;
                CVV = cvv;
            }

        }
    }
}
