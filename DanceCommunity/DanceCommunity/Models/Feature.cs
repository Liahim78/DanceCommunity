//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DanceCommunity.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feature
    {
        public int Id { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<int> IdSchool { get; set; }
        public Nullable<int> IdTeam { get; set; }
        public Nullable<int> IdMeeting { get; set; }
        public string UrlVideoContent { get; set; }
        public string UrlPhotoContent { get; set; }
        public bool Private_Public { get; set; }
        public bool TypeNew { get; set; }
        public Nullable<int> IdNew { get; set; }
        public string Style { get; set; }
        public string TypeOfStyle { get; set; }
    
        public virtual Meeting Meeting { get; set; }
        public virtual School School { get; set; }
        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}
