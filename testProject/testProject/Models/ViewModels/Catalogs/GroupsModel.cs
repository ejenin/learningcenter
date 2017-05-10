using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testProject.Models.ViewModels.Catalogs.Shared;

namespace testProject.Models.ViewModels.Catalogs {
    public class GroupsModel {
        public List<Group> Groups { get; set; }

        public GroupsModel() {
            Groups = new List<Group>();
        }
    }
}