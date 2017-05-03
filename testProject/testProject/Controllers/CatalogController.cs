using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testProject.Misc;
using testProject.Models.ViewModels.Catalogs;
using testProject.Models.ViewModels.Catalogs.Shared;

namespace testProject.Controllers
{
    public class CatalogController : Controller
    {
        [HttpGet, ActionName("areas")]
        public ActionResult Areas(int? page) {

            AreasModel model = new AreasModel();
            return View(model);
        }

        [HttpPost, ActionName("saveArea")]
        public void SaveArea(string Id, string Address, string Comment) {
            //string comm = Globals.StringIsEmpty(area.Comment) ? "NULL" : area.Comment;
            //string query = "INESRT INTO Areas VALUES('" + area.Address + "'," + comm + ", 0)";
            //DbMess.DoAction(query);

            string comm = Globals.StringIsEmpty(Comment) ? "NULL" : "'" + Comment + "'";
            string query = "UPDATE Areas SET Address='" + Address + "', Comment=" + comm + " WHERE IdArea=" + Id;
            DbMess.DoAction(query);
        }

        [HttpPost, ActionName("addArea")]
        public void AddArea(string Id, string Address, string Comment) {
            string comm = Globals.StringIsEmpty(Comment) ? "NULL" : "'" + Comment + "'";
            string query = "INSERT INTO Areas VALUES('" + Address + "'," + comm + ", 0)";
            DbMess.DoAction(query);
        }

        [HttpPost, ActionName("deleteArea")]
        public void DeleteArea(string Id) {
            string query = "UPDATE Areas SET IsDeleted=1 WHERE IdArea=" + Id;
            DbMess.DoAction(query);
        }
    }
}
