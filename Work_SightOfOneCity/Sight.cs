//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Work_SightOfOneCity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sight()
        {
            this.AuthorOfSight = new HashSet<AuthorOfSight>();
            this.TransportToSight = new HashSet<TransportToSight>();
            this.WorkDays = new HashSet<WorkDays>();
        }
        public Sight (long ID, string NameSight, string DescriptionSight, string Photo, string AddresSight, byte StopID, byte StatusID, byte CategoryID)
        {
            this.ID = ID;
            this.NameSight = NameSight;
            this.DescriptionSight = DescriptionSight;
            this.Photo = Photo;
            this.AddresSights = AddresSight;
            this.StopID = StopID;
            this.StatusID = StatusID;
            this.CategoryID = CategoryID;
        }

        public Sight(string NameSight, string DescriptionSight, string Photo, string AddresSight, byte StopID, byte StatusID, byte CategoryID)
        {
            this.NameSight = NameSight;
            this.DescriptionSight = DescriptionSight;
            this.Photo = Photo;
            this.AddresSights = AddresSight;
            this.StopID = StopID;
            this.StatusID = StatusID;
            this.CategoryID = CategoryID;
        }

        public long ID { get; set; }
        public string NameSight { get; set; }
        public string DescriptionSight { get; set; }
        public string Photo { get; set; }
        public string AddresSights { get; set; }
        public byte StopID { get; set; }
        public byte StatusID { get; set; }
        public byte CategoryID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuthorOfSight> AuthorOfSight { get; set; }
        public virtual Category Category { get; set; }
        public virtual StatusSight StatusSight { get; set; }
        public virtual TransportStop TransportStop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportToSight> TransportToSight { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkDays> WorkDays { get; set; }
    }
}
