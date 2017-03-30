using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Models.ViewModels.MyGroups {
    public class Group {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Area { get; set; }
        public string Course { get; set; }
    }
}