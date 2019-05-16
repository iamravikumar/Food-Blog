//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restopedia.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public partial class Review
    {
        public int ReviewId { get; set; }
        public string Body { get; set; }
        public decimal Rating { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int RestaurantId { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int UserId { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
        public virtual User User { get; set; }
    }
}
