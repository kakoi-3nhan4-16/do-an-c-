//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api_gamebai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class room_list
    {
        public int id { get; set; }
        public int owner_id { get; set; }
        public int limit_player { get; set; }
        public string password { get; set; }
        public Nullable<int> current_player { get; set; }
    }
}
