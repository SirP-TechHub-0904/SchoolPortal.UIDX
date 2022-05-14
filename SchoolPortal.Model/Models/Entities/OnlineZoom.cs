﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.Model.Web.Models.Entities
{
    public class OnlineZoom
    {
        public int Id { get; set; }
        public string HostEmail { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public long? MeetingId { get; set; }
        public string MeetingUUId { get; set; }
        public string ClassDate { get; set; }
        public string ClassTime { get; set; }
        public string Duration { get; set; }
        public int ClassLevelId { get; set; }
        public ClassLevel ClassLevel { get; set; }
        public int? SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }

        public string Description { get; set; }
        public string ClassPassword { get; set; }
        public string MeetingType { get; set; }
        public DateTime DateCreated { get; set; }

    }
}