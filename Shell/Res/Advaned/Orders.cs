//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shell.Res.Advaned
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.ServiceList = new HashSet<ServiceList>();
        }
    
        public int ID_Order { get; set; }
        public string Order_code { get; set; }
        public Nullable<System.DateTime> Date_of_creation { get; set; }
        public Nullable<System.TimeSpan> Order_time { get; set; }
        public string Client_code { get; set; }
        public Nullable<int> Status_ID { get; set; }
        public Nullable<System.DateTime> Closing_date { get; set; }
        public string ArendTime { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Order_Status Order_Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceList> ServiceList { get; set; }
    }
}
