using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Models.ViewModels.MyGroups {
    public class MyLearningModel {

        public List<Group> actualGroups;
        public List<Group> futureGroups;
        public List<LearningResult> passedGroups;

        public MyLearningModel() {
            actualGroups = new List<Group>();
            futureGroups = new List<Group>();
            passedGroups = new List<LearningResult>();
        }
    }
}