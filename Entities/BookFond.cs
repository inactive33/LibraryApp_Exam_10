//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryApp_Exam_10.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookFond
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookFond()
        {
            this.Vedomost = new HashSet<Vedomost>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int avtor_id { get; set; }
        public string izdatelstvo { get; set; }
        public bool IsHave { get; set; }
    
        public virtual Avtors Avtors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vedomost> Vedomost { get; set; }
    }
}
