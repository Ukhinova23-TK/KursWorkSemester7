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
    
    public partial class WorkDays
    {
        public long ID { get; set; }
        public byte NameDayOfWeek { get; set; }
        public long SightID { get; set; }
    
        public virtual Sight Sight { get; set; }
    }
}
