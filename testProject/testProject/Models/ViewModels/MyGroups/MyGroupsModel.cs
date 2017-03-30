using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Models.ViewModels.MyGroups {
    public class MyGroupsModel {
        public List<Group> groups;

        public MyGroupsModel() {
            groups = new List<Group>();
        }
    }
}