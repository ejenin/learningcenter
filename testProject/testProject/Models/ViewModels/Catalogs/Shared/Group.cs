using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Models.ViewModels.Catalogs.Shared {
    public class Group {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public int? AreaId { get; set; }
        public string AreaName { get; set; }

        public int? LecturerId { get; set; }
        public string LecturerName { get; set; }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}