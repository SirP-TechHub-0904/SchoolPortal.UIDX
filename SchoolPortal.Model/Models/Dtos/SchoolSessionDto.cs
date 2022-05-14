﻿using SchoolPortal.Model.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.Model.Web.Models.Dtos
{
    public class SchoolSessionDto
    {
        public int Id { get; set; }
        public string FullSession { get; set; }
        public SessionStatus SessionStatus { get; set; }
    }
}