//------------------------------------------------------------------------------
// <auto-generated>
//    Bu kod bir şablondan oluşturuldu.
//
//    Bu dosyada el ile yapılan değişiklikler uygulamanızda beklenmedik davranışa neden olabilir.
//    Kod yeniden oluşturulursa, bu dosyada el ile yapılan değişikliklerin üzerine yazılacak.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFinancialCrmm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bills
    {
        public int BillId { get; set; }
        public string BillTitle { get; set; }
        public Nullable<decimal> BillAmount { get; set; }
        public string BillPeriod { get; set; }
    }
}
