using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //tüzel müşteri
    //miras-inheritance
    class CorporateCustomer:Customer
    {
        public string CompanyName { get; set; }

        public string TaxNo { get; set; }

    }
}
