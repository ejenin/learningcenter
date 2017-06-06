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
    public class CatalogController : Controller {
        #region AREAS
        [HttpGet, ActionName("areas")]
        public ActionResult Areas(int? page) {

            AreasModel model = new AreasModel();
            return View(model);
        }

        [HttpPost, ActionName("saveArea")]
        public void SaveArea(string Id, string Address, string Comment) {
            string comm = Globals.StringIsEmpty(Comment) ? "NULL" : "'" + Comment + "'";
            string query = "UPDATE Areas SET Address='" + Address + "', Comment=" + comm + " WHERE IdArea=" + Id;
            DbMess.DoAction(query);
        }

        [HttpPost, ActionName("addArea")]
        public void AddArea(string Id, string Address, string Comment) {
            if (!Globals.StringIsEmpty(Address)) {
                string comm = Globals.StringIsEmpty(Comment) ? "NULL" : "'" + Comment + "'";
                string query = "INSERT INTO Areas VALUES('" + Address + "'," + comm + ", 0)";
                DbMess.DoAction(query);
            }
        }

        [HttpPost, ActionName("deleteArea")]
        public void DeleteArea(string Id) {
            string query = "UPDATE Areas SET IsDeleted=1 WHERE IdArea=" + Id;
            DbMess.DoAction(query);
        }
        #endregion

        #region COURSES
        [HttpGet, ActionName("courses")]
        public ActionResult Courses(int? page) {
            CoursesModel model = new CoursesModel();
            return View(model);
        }

        [HttpPost, ActionName("saveCourse")]
        public void SaveCouse(string Id, string Name, bool IsRemote, string Length, string Type) {

            double finalLength = 0;
            string length = "";
            if (double.TryParse(Length, out finalLength)) {
                length = finalLength.ToString();
            }
            else {
                length = "NULL";
            }

            string query = "UPDATE Courses SET Name='" + Name + "', IsRemote=" + Convert.ToInt32(IsRemote) + ", LengthInHours=" + length + ", ResultType=" + Type + " WHERE IdCourse=" + Id;
            DbMess.DoAction(query);
        }

        [HttpPost, ActionName("addCourse")]
        public void addCouse(string Id, string Name, bool IsRemote, string Length, string Type) {

            double finalLength = 0;
            string length = "";
            if (double.TryParse(Length, out finalLength)) {
                length = finalLength.ToString();
            }
            else {
                length = "NULL";
            }

            string query = "INSERT INTO Courses VALUES('" + Name + "', " + Convert.ToInt32(IsRemote) + ", " + length + ", " + Type + ", 0)";
            DbMess.DoAction(query);
        }

        [HttpPost, ActionName("deleteCourse")]
        public void DeleteCourse(string Id) {
            string query = "UPDATE Courses SET IsDeleted=1 WHERE IdCourse=" + Id;
            DbMess.DoAction(query);
        }
        #endregion

        #region GROUPS (NOT DONE)
        [HttpGet, ActionName("groups")]
        public ActionResult Groups(int? page) {
            GroupsModel model = new GroupsModel();
            return View(model);
        }
        #endregion

        #region LECTURERS (NOT DONE)
        [HttpGet, ActionName("lecturers")]
        public ActionResult Lecturers(int? page) {
            LecturersModel model = new LecturersModel();
            return View(model);
        }

        [HttpPost, ActionName("SaveLecturer")]
        public ActionResult SaveLecturer(string Id, string FIO, string OrganizationId, string Email, string Phone, HttpPostedFileBase newAvatar) {

            Console.WriteLine("bp");

            //1) сохранить фотографию

            string query = "";

            if (newAvatar != null) {
                string fileName = Globals.GetRandomName(10);
                string avatarExtension = "." + newAvatar.FileName.Split('.').Last();
                string picturePath = null;

                string normalPath = "/Files/Avatars/" + fileName + avatarExtension;

                picturePath = Server.MapPath("~/Files/Avatars/" + fileName + avatarExtension);
                newAvatar.SaveAs(picturePath);

                //2) проверить, есть ли уже у этого препода фотография
                query = "SELECT AvatarFileId FROM Lecturers WHERE IdLecturer=" + Id;
                string fileId = DbMess.GetValue(query);
                if (!Globals.StringIsEmpty(fileId)) {
                    //3.a) если есть, заменить путь
                    query = "UPDATE Files SET Path='" + picturePath + "' WHERE IdFile=" + fileId;
                    DbMess.DoAction(query);
                }
                else {
                    //3.b) если нет, инсёртнуть, забрать айдишник, и обновить поле у проеподавателя
                    query = "INSERT INTO FILES VALUES('" + picturePath + "', '" + normalPath + "', GETDATE())";
                    DbMess.DoAction(query);

                    query = "SELECT MAX(IdFile) FROM Files";

                    query = "UPDATE Lecturers SET AvatarFileId=" + DbMess.GetValue(query);
                    DbMess.DoAction(query);
                }
            }

            string org = Globals.StringIsEmpty(OrganizationId) ? "NULL" : OrganizationId;
            string mail = Globals.StringIsEmpty(Email) ? "NULL" : "'" + Email + "'";
            string phone = Globals.StringIsEmpty(Phone) ? "NULL" : "'" + Phone + "'";
            //теперь обновить остальные поля ))
            query = "UPDATE Lecturers SET FIO='" + FIO + "', OrganizationId=" + org + ", Email=" + mail + ", ContactPhone=" + phone + " WHERE IdLecturer=" + Id;
            DbMess.DoAction(query);

            return Redirect("/catalog/lecturers");
        }
        #endregion

        #region ORGANIZATIONS
        [HttpGet, ActionName("organizations")]
        public ActionResult Organizations(int? page) {
            OrganizationsModel model = new OrganizationsModel();
            return View(model);
        }

        [HttpPost, ActionName("SaveOrganization")]
        public void SaveOrganization(string Id, string Name, string Mail, string Phone, string Fio) {
            string mail = Globals.StringIsEmpty(Mail) ? "NULL" : "'" + Mail + "'";
            string phone = Globals.StringIsEmpty(Phone) ? "NULL" : "'" + Phone + "'";
            string fio = Globals.StringIsEmpty(Fio) ? "NULL" : "'" + Fio + "'";

            string query = "UPDATE Organizations SET Name='" + Name + "', Email=" + mail + ",Phone=" + phone + ", ContactFio=" + fio + " WHERE IdOrganization=" + Id;
            DbMess.DoAction(query);
        }

        [HttpPost, ActionName("AddOrganization")]
        public void AddOrganization(string Id, string Name, string Mail, string Phone, string Fio) {
            string mail = Globals.StringIsEmpty(Mail) ? "NULL" : "'" + Mail + "'";
            string phone = Globals.StringIsEmpty(Phone) ? "NULL" : "'" + Phone + "'";
            string fio = Globals.StringIsEmpty(Fio) ? "NULL" : "'" + Fio + "'";

            string query = "INSERT INTO Organizations VALUES('" + Name + "'," + mail + "," + phone + "," + fio + ", 0)";
            DbMess.DoAction(query);
        }

        [HttpPost, ActionName("DeleteOrganization")]
        public void DeleteOrganization(string id) {
            string query = "UPDATE Organizations SET IsDeleted=1 WHERE IdOrganization=" + id;
            DbMess.DoAction(query);
        }
        #endregion
    }
}
