//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookingRestaurant.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int order_id { get; set; }
        public Nullable<int> booking_id { get; set; }
        public Nullable<int> menu_item_id { get; set; }
        public int quantity { get; set; }
        public string note { get; set; }
    
        public virtual Booking Booking { get; set; }
        public virtual MenuItem MenuItem { get; set; }
    }
}
