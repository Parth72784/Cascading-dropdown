//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cascadingdropdown.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StateMaster
    {
        public int pkStateId { get; set; }
        public string ukStateZipCode { get; set; }
        public string ukStateName { get; set; }
        public int refCountryId { get; set; }
    
        public virtual CountryMaster CountryMaster { get; set; }
    }
}
