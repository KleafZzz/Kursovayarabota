//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursovayarabota.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Options
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Options()
        {
            this.Sportsmen = new HashSet<Sportsmen>();
        }
    
        public int id { get; set; }
        public string Competitive_load { get; set; }
        public string training_load { get; set; }
        public string Workout_time { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sportsmen> Sportsmen { get; set; }
    }
}
