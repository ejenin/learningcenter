using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public enum CourseResultType {
    Mark,
    Sertificate,
    Presence
}

namespace testProject.Models.ViewModels.Catalogs.Shared {
    public class Course {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRemote { get; set; }
        public double LengthInHours { get; set; }
        public CourseResultType ResultType { get; set; }

        public string GetCourseResultType() {
            switch (ResultType) {
                case CourseResultType.Sertificate:
                    return "Сертификат";
                case CourseResultType.Presence:
                    return "Присутствие";
                case CourseResultType.Mark:
                    return "Оценка";
                default:
                    return "";
            }
        }

        public string GetLength() {
            if (LengthInHours == -1)
                return "-";
            else
                return LengthInHours.ToString();
        }

        public string GetForm() {
            if (IsRemote)
                return "Дистанционная";
            else
                return "Очная";
        }
    }
}