using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testProject.Models.ViewModels.MyGroups;

namespace testProject.Models.ViewModels.Planning {

    public enum Status {
        NaSoglasovanii = 3,
        Soglasovana = 0,
        Otkazana = 1,
        IzmenenoRukovoditelem = 4,
        None = 2
    }

    public class LearningCourse {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRemote { get; set; }
        public Status Status { get; set; }

        public List<Group> LearningGroups;

        public Group ChosenGroup { get; set; }
        public DateTime DataSoglasovaniya { get; set; }

        public LearningCourse() {
            LearningGroups = new List<Group>();
            LearningGroups.Add(new Group() {
                Id = 1,
                GroupName = "17-67-2098",
                Course = "TEST",
                Area = "Тобольск, 9мкр, дом 1",
                DateStart = new DateTime(2017, 04,12),
                DateEnd = new DateTime(2017, 04, 24)
            });

            LearningGroups.Add(new Group() {
                Id = 1,
                GroupName = "17-67-2099",
                Course = "TEST",
                Area = "Тобольск, 9мкр, дом 1",
                DateStart = new DateTime(2017, 05, 01),
                DateEnd = new DateTime(2017, 05, 03)
            });
        }

        public string GetStatus() {
            switch (Status) {
                case Planning.Status.NaSoglasovanii:
                    return "На согласовании у руководителя";
                case Planning.Status.Otkazana:
                    return "Отказано";
                case Planning.Status.Soglasovana:
                    return "Согласовано руководителем";
                case Planning.Status.IzmenenoRukovoditelem:
                    return "Изменено руководителем";
            }
            return "-";
        }
    }
}