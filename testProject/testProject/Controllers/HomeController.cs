using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testProject.Models.ViewModels;
using testProject.Models.ViewModels.MyGroups;
using testProject.Models.ViewModels.Planning;

namespace testProject.Controllers {
    public class HomeController : Controller {
        //
        // GET: /Home/

        public ActionResult Feed() {
            FeedModel feed = new FeedModel();
            feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
                Id = 0,
                CreateDate = DateTime.Now,
                Text = "Пример информационной новости",
                Header = "Заголовок информационной непрочитанной новости",
                Type = Models.ViewModels.Feed.NewsType.Information,
                ReaderId = 0,
                IsReaded = false
            });

            feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
                Id = 1,
                CreateDate = DateTime.Now,
                Text = "Пример позитивной новости",
                Header = "Заголовок позитивной непрочитанной новости",
                Type = Models.ViewModels.Feed.NewsType.Positive,
                ReaderId = 0,
                IsReaded = false
            });

            feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
                Id = 2,
                CreateDate = DateTime.Now,
                Text = "Пример негативной новости",
                Header = "Заголовок негативной непрочитанной новости",
                Type = Models.ViewModels.Feed.NewsType.Negative,
                ReaderId = 0,
                IsReaded = false
            });

            feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
                Id = 3,
                CreateDate = DateTime.Now,
                Text = "Пример информационной новости",
                Header = "Заголовок информационной прочитанной новости",
                Type = Models.ViewModels.Feed.NewsType.Information,
                ReaderId = 0,
                IsReaded = true
            });

            feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
                Id = 4,
                CreateDate = DateTime.Now,
                Text = "Пример позитивной новости",
                Header = "Заголовок позитивной прочитанной новости",
                Type = Models.ViewModels.Feed.NewsType.Positive,
                ReaderId = 0,
                IsReaded = true
            });

            feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
                Id = 5,
                CreateDate = DateTime.Now,
                Text = "Пример негативной новости",
                Header = "Заголовок негативной прочитанной новости",
                Type = Models.ViewModels.Feed.NewsType.Negative,
                ReaderId = 0,
                IsReaded = true
            });

            feed.newsToShow = feed.newsToShow.OrderByDescending(n => n.Id).ToList();

            return View(feed);
        }

        public ActionResult MyLearning() {
            MyLearningModel model = new MyLearningModel();

            DateTime start = new DateTime(2017, 03, 19);
            DateTime end = new DateTime(2017, 03, 24);

            model.actualGroups.Add(new Group() {
                Id = 3,
                DateStart = new DateTime(2017, 04, 04),
                DateEnd = new DateTime(2017, 04, 16),
                GroupName = "17-67-0004",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Иванов И.И."
            });



            model.futureGroups.Add(new Group() {
                Id = 0,
                DateStart = new DateTime(2017, 05, 15),
                DateEnd = new DateTime(2017, 05, 17),
                GroupName = "17-67-0001",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Иванов И.И."
            });

            model.futureGroups.Add(new Group() {
                Id = 0,
                DateStart = new DateTime(2017, 06, 01),
                DateEnd = new DateTime(2017, 06, 03),
                GroupName = "17-67-0001",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Иванов И.И."
            });



            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = new DateTime(2017, 02, 01),
                    DateEnd = new DateTime(2017, 02, 03),
                    GroupName = "17-67-0001",
                    Area = "г. Тобольск, 9 мкр.",
                    Course = "Курс 1",
                    Lecturer = "Иванов И.И."
                },
                IsSuccess = true,
                Mark = "4"
            });

            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = new DateTime(2017, 02, 05),
                    DateEnd = new DateTime(2017, 02, 07),
                    GroupName = "17-67-0001",
                    Area = "г. Тобольск, 9 мкр.",
                    Course = "Курс 1",
                    Lecturer = "Иванов И.И."
                },
                IsSuccess = false,
                Mark = "2"
            });

            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = new DateTime(2017, 02, 10),
                    DateEnd = new DateTime(2017, 02, 15),
                    GroupName = "17-67-0001",
                    Area = "г. Тобольск, 9 мкр.",
                    Course = "Курс 1",
                    Lecturer = "Иванов И.И."
                },
                IsSuccess = false,
                Mark = "Пропуск занятия"
            });

            return View(model);
        }

        public ActionResult Planning() {
            PlanningModel model = new PlanningModel();
            model.BossFio = "Петров Пётр Петрович";
            model.ochnCourses = new List<LearningCourse>();

            model.ochnCourses.Add(new LearningCourse() {
                Id = 1,
                Name = "Мастерство владения холодными звонками (уровень 2)",
                IsRemote = false,
                Status = Status.None
            });

            model.ochnCourses.Add(new LearningCourse() {
                Id = 2,
                Name = "Мастерство владения холодными (уровень 1)",
                IsRemote = false,
                Status = Status.NaSoglasovanii
            });

            model.ochnCourses.Add(new LearningCourse() {
                Id = 3,
                Name = "Курсы по EXCEL 2010",
                IsRemote = false,
                Status = Status.Otkazana,
                DataSoglasovaniya = new DateTime(2017, 03, 30)
            });

            model.ochnCourses.Add(new LearningCourse() {
                Id = 3,
                Name = "Развитие лидерских качеств",
                IsRemote = false,
                Status = Status.Soglasovana,
                ChosenGroup = new Group() {
                    Area = "г. Тобольск, ул. Мира, 19",
                    DateStart = new DateTime(2017, 04, 10),
                    DateEnd = new DateTime(2017, 04, 12),
                    GroupName = "17-67-2099",
                    Lecturer = "Иванов Е.С."
                },
                DataSoglasovaniya = new DateTime(2017,04,13)
            });

            model.distCourses.Add(new LearningCourse() {
                Id = 4,
                Name = "Обращение с подарками",
                IsRemote = true,
                Status = Status.None
            });

            model.distCourses.Add(new LearningCourse() {
                Id = 5,
                Name = "Проблемы при работе с кредитами",
                IsRemote = true,
                Status = Status.None
            });

            model.distCourses.Add(new LearningCourse() {
                Id = 6,
                Name = "Соло на клавиатуре",
                IsRemote = true,
                Status = Status.None
            });

            model.ochnCourses = model.ochnCourses.OrderBy(o => o.Status).ToList();

            return View(model);
        }

    }
}