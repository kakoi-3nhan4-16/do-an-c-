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
    
    public partial class shop_game
    {
        public int id_item { get; set; }
        public string name_item { get; set; }
        public Nullable<System.DateTime> limit_day { get; set; }
        public decimal cost { get; set; }
        public string image { get; set; }
        public bool isEnable { get; set; }
        public string type_item { get; set; }
        public Nullable<int> duration_day_ { get; set; }
        public string descript { get; set; }
    }
}