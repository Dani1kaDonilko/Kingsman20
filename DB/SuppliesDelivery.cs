//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kingsman.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SuppliesDelivery
    {
        public int ID { get; set; }
        public int SupllierID { get; set; }
        public int MaterialID { get; set; }
        public int Quantity { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
