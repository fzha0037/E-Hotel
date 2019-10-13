//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Hotelv4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Reservation
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Check-In Date")]
        public System.DateTime CheckinDate { get; set; }

        [Required]
        [Display(Name = "Check-Out Date")]
        public System.DateTime CheckoutDate { get; set; }

        [Required]
        [Display(Name = "Room Type")]
        [StringLength(50)]
        public string RoomType { get; set; }

        public int HotelId { get; set; }
        public string UserId { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}
    