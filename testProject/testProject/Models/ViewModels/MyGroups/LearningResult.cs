using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Models.ViewModels.MyGroups {
    public class LearningResult {
        public Group Group;
        public bool IsSuccess { get; set; }
        public string Mark { get; set; }

        public string getClass() {
            //return "group_" + (IsSuccess ? "done" : "failed");
            return IsSuccess ? "success" : "not_success";
        }
    }
}