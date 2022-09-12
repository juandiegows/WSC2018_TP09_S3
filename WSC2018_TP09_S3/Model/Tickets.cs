//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSC2018_TP09_S3.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tickets
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ScheduleID { get; set; }
        public int CabinTypeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PassportNumber { get; set; }
        public int PassportCountryID { get; set; }
        public string PassportPhoto { get; set; }
        public string BookingReference { get; set; }
        public bool Confirmed { get; set; }
    
        public virtual CabinTypes CabinTypes { get; set; }
        public virtual Schedules Schedules { get; set; }
        public virtual Users Users { get; set; }
    }
}
