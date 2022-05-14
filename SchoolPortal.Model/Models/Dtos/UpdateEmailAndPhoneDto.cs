using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.Model.Web.Models.Dtos
{
    public class UpdateEmailAndPhoneDto
    {
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string UserId { get; set; }
    }
}