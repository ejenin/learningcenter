using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testProject.Misc;
using testProject.Models.ViewModels.Catalogs.Shared;

namespace testProject.Models.ViewModels.Catalogs {
    public class OrganizationsModel {

        public List<Organization> Organizations { get; set; }

        public OrganizationsModel() {
            Organizations = new List<Organization>();

            string query = "SELECT * FROM Organizations WHERE IsDeleted=0";

            var res = DbMess.GetTable(query);

            for (int i = 0; i < res.Rows.Count; i++) {
                Organizations.Add(new Organization() {
                    Id = Convert.ToInt32(res.Rows[i][0].ToString()),
                    Name = res.Rows[i][1].ToString(),
                    Email = res.Rows[i][2].ToString(),
                    Phone = res.Rows[i][3].ToString(),
                    ContactFio = res.Rows[i][4].ToString()
                });
            }
        }
    }
}