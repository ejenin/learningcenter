using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Models.ViewModels.Planning {
    public class PlanningModel {
        public string BossFio { get; set; }

        public List<LearningCourse> ochnCourses;
        public List<LearningCourse> distCourses;

        public PlanningModel() {
            ochnCourses = new List<LearningCourse>();
            distCourses = new List<LearningCourse>();
        }
    }
}