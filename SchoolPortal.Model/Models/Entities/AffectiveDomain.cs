﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.Model.Web.Models.Entities
{
    public class AffectiveDomain
    {
        public AffectiveDomain()
        {
            Attentiveness = "Good";
            Honesty = "Good";
            Neatness = "Good";
            Punctuality = "Good";
            Relationship = "Good";
        }
        public int Id { get; set; }
        public string Attentiveness { get; set; }
        public string Honesty { get; set; }
        public string Neatness { get; set; }
        public string Punctuality { get; set; }
        public string Relationship { get; set; }
        public int EnrolmentId { get; set; }
    }
}