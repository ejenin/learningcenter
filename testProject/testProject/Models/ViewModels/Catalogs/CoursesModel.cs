using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testProject.Misc;
using testProject.Models.ViewModels.Catalogs.Shared;

namespace testProject.Models.ViewModels.Catalogs {
    public class CoursesModel {
        public List<Course> Courses { get; set; }

        public CoursesModel() {
            Courses = new List<Course>();

            string query = "SELECT IdCourse, Name, IsRemote, LengthInHours, ResultType FROM Courses WHERE IsDeleted=0";

            var table = DbMess.GetTable(query);

            for (int i = 0; i < table.Rows.Count; i++) {
                Courses.Add(new Course() {
                    Id = Convert.ToInt32(table.Rows[i][0]),
                    Name = table.Rows[i][1].ToString(),
                    IsRemote = Convert.ToBoolean(table.Rows[i][2].ToString()),
                    LengthInHours = Globals.StringIsEmpty(table.Rows[i][3].ToString()) ? -1 : Convert.ToDouble(table.Rows[i][3].ToString()),
                    ResultType = Globals.StringIsEmpty(table.Rows[i][4].ToString()) ? CourseResultType.Presence : Convert.ToBoolean(table.Rows[i][4].ToString()) ? CourseResultType.Mark : CourseResultType.Sertificate
                });
            }
        }
    }
}