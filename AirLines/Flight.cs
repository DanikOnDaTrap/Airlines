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
    
    public partial class Flight
    {
        public String[] str = {"ID","DateTime", "RouteDetail", "PlaneDetail", "Canceled" };
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            this.Ticket = new HashSet<Ticket>();
        }
    
        public int ID { get; set; }
        public System.DateTime DateTime { get; set; }
        public int Route { get; set; }
        public string RouteDetail 
        {
            get
            {
                return $"{Route1.DepartureAirport}-{Route1.DestinationAirport}";
            }
        }
        public int Plane { get; set; }
        public string PlaneDetail 
        { 
            get
            {
                return $"{Plane1.Model}-{Plane1.ID}";
            }
        }
        
        public bool Canceled { get; set; }
    
        public virtual Plane Plane1 { get; set; }
        public virtual Route Route1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
