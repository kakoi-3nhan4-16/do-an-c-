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
    
    public partial class player_inventory
    {
        public int id { get; set; }
        public int player_id { get; set; }
        public int item_id { get; set; }
        public Nullable<System.DateTime> limit_day { get; set; }
        public string image_item { get; set; }
        public string type_item { get; set; }
        public Nullable<int> duration { get; set; }
    
        public virtual player player { get; set; }
    }
}
