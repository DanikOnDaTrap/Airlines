//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirLines
{
    using System;
    using System.Collections.Generic;
    
    public partial class Commander
    {
        public String[] str = {"ID","Surname","Name","Patronymic","Adress","PhoneNumber","FlyingHours"};

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commander()
        {
            this.Plane = new HashSet<Plane>();
        }
    
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public int FlyingHours { get; set; }
        public string CommanderDetail
        {
            get
            {
                return $"{this.ID}:{this.Surname} {this.Name} {this.Patronymic}";
            }
        }

    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plane> Plane { get; set; }
    }
}
