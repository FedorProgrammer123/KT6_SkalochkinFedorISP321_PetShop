//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KT6_SkalochkinFedorISP321_PetShop.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompleteOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompleteOrder()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int ID_CompleteOrder { get; set; }
        public string FirstPart { get; set; }
        public int SecondPart { get; set; }
        public string ThirdPart { get; set; }
        public int FourthPart { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
