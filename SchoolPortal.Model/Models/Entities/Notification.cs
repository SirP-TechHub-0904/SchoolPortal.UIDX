﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolPortal.Model.Web.Models.Entities
{
    public class Notification
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [AllowHtml]
        public string Message { get; set; }

        [Display(Name = "Show Modal")]
        public bool ShowModal { get; set; }

        [Display(Name = "Show Marque")]
        public bool ShowMarque { get; set; }
    }
}