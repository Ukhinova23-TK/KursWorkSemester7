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
    
    public partial class AuthorOfSight
    {
        public AuthorOfSight(long SightID, long AuthorID, short DateCreate)
        {
            this.SightID = SightID;
            this.AuthorID = AuthorID;
            this.DateCreate = DateCreate;
        }

        public AuthorOfSight()
        {
        }

        public long SightID { get; set; }
        public long AuthorID { get; set; }
        public short DateCreate { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Sight Sight { get; set; }
    }
}
