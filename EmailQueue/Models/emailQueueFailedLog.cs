//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmailQueue.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class emailQueueFailedLog
    {
        public int ID { get; set; }
        public string ETo { get; set; }
        public Nullable<int> Tries { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
        public Nullable<System.TimeSpan> ETime { get; set; }
    }
}
