//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PenaltyCalculation
{
    using System;
    using System.Collections.Generic;
    
    public partial class CountryHoliday
    {
        public int id { get; set; }
        public byte deleted { get; set; }
        public int CountryId { get; set; }
        public System.DateTime CountryHolidayDate { get; set; }
    
        public virtual Country Country { get; set; }
    }
}
