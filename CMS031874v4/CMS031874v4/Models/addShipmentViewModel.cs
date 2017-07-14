using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS031874v4.Models
{
    public class addShipmentViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Booking Date")]
        public string Booking_date { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Shipping Date")]
        public string Shipping_date { get; set; }
        [Required]
        [Display(Name = "Destination")]
        public string Destination { get; set; }
        [Required]
        [Display(Name = "Type")]
        public string Shipping_type { get; set; }
        [Required]
        [Display(Name = "Weight (Kg)")]
        public string Shipping_weight { get; set; }
        [Required]
        [Display(Name = "Ship Registration number")]
        public string Ship_regnum { get; set; }

        public List<SelectListItem> listItem { get; set; }
    }
}