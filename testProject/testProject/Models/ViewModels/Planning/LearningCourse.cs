using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testProject.Models.ViewModels.MyGroups;

namespace testProject.Models.ViewModels.Planning {
    public class LearningCourse {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRemote { get; set; }
        public List<Group> LearningGroups;

        public LearningCourse() {
            LearningGroups = new List<Group>();
            LearningGroups.Add(new Group() {
                Id = 1,
                GroupName = "17-67-2098 TEST",
                Course = "TEST",
                Area = "Тобольск, 9мкр, дом 1",
                DateStart = new DateTime(2017,01,12),
                DateEnd = new DateTime(2017, 01, 24)
            });
        }
    }
}