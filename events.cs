//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppEvents
{
    using System;
    using System.Collections.Generic;
    
    public partial class events
    {
        public int Id_events { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public System.DateTime datatime_begin { get; set; }
        public System.DateTime datatime_end { get; set; }
        public int year { get; set; }
    
        public virtual staff_event staff_event { get; set; }
    }
}