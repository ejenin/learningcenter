using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testProject.Misc;
using testProject.Models.ViewModels.Catalogs.Shared;

namespace testProject.Models.ViewModels.Catalogs {
    public class AreasModel {
        public List<Area> Areas { get; set; }

        public AreasModel() {
            Areas = new List<Area>();

            string query = "SELECT IdArea, Address, Comment FROM Areas WHERE IsDeleted=0 ORDER BY 1 ASC";

            var table = DbMess.GetTable(query);

            for (int i = 0; i < table.Rows.Count; i++) {
                Areas.Add(new Area() {
                    Id = table.Rows[i][0].ToString(),
                    Address = table.Rows[i][1].ToString(),
                    Comment  = table.Rows[i][2].ToString()
                });
            }
        }
    }
}