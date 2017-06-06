using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testProject.Misc;
using testProject.Models.ViewModels.Catalogs.Shared;

namespace testProject.Models.ViewModels.Catalogs {
    public class LecturersModel {
        public List<Lecturer> Lecturers { get; set; }

        public List<string> OrganizationIds { get; set; }
        public List<string> OrganizationNames { get; set; }

        public string JSCode1 { get; set; }
        public string JSCode2 { get; set; }

        public LecturersModel() {
            Lecturers = new List<Lecturer>();
            OrganizationIds = new List<string>();
            OrganizationNames = new List<string>();

            string query = "SELECT L.IdLecturer, L.FIO, L.OrganizationId, L.AvatarFileId, L.Email, L.ContactPhone, F.RelativePath, O.Name FROM Lecturers AS L LEFT JOIN Organizations AS O ON L.OrganizationId=O.IdOrganization LEFT JOIN Files AS F ON L.AvatarFileId=F.IdFile WHERE L.IsDeleted=0";

            var table = DbMess.GetTable(query);

            for (int i = 0; i < table.Rows.Count; i++) {
                Lecturers.Add(new Lecturer() {
                    Id = Convert.ToInt32(table.Rows[i][0].ToString()),
                    FIO = table.Rows[i][1].ToString(),
                    OrganizationId = Globals.GetSafeIntVal(table.Rows[i][2].ToString()),
                    FileId = Globals.GetSafeIntVal(table.Rows[i][3].ToString()),
                    Email = table.Rows[i][4].ToString(),
                    ContactPhone = table.Rows[i][5].ToString(),
                    FilePath = table.Rows[i][6].ToString(),
                    OrganizationName = table.Rows[i][7].ToString()
                });
            }

            query = "SELECT IdOrganization, Name FROM Organizations WHERE IsDeleted=0";
            table = DbMess.GetTable(query);
            for (int i = 0; i < table.Rows.Count; i++) {
                OrganizationIds.Add(table.Rows[i][0].ToString());
                OrganizationNames.Add(table.Rows[i][1].ToString());
            }

            JSCode1 = "var availableOrgs = [";

            for (int i = 0; i < OrganizationIds.Count; i++) {
                JSCode1 += " {label:\"" + OrganizationNames[i] + "\", idwka:\"" + OrganizationIds[i] + "\", value:\"" + OrganizationNames[i] + "\"}";
                if (i != OrganizationIds.Count - 1)
                    JSCode1 += ",";
            }

            JSCode1 += "];";


            JSCode2 = "var availableCourses = [";

            query = "SELECT IdCourse, Name FROM Courses WHERE IsDeleted=0";
            
            table = DbMess.GetTable(query);

            for (int i = 0; i < table.Rows.Count; i++) {
                JSCode2 += " {label:\"" + table.Rows[i][1].ToString() + "\", idwka:\"" + table.Rows[i][0].ToString() + "\", value:\"" + table.Rows[i][1].ToString() + "\"}";
                if (i != table.Rows.Count - 1)
                    JSCode2 += ",";
            }

            JSCode2 += "];";
        }
    }
}