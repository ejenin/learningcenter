using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Models.ViewModels.MyGroups {
    public class MyLearningModel {
        public List<Group> groups;

        public MyLearningModel() {
            groups = new List<Group>();
        }
    }
}