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
    
    public partial class PickUpPoint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PickUpPoint()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int ID_PickupPoint { get; set; }
        public int PostIndex { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public Nullable<int> House { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
