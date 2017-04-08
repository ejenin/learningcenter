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
                DateStart = start,
                DateEnd = end,
                GroupName = "17-67-0004",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Бояркина Е.В."
            });

            model.actualGroups.Add(new Group() {
                Id = 2,
                DateStart = start,
                DateEnd = end,
                GroupName = "17-67-0003",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Бояркина Е.В."
            });

            model.actualGroups.Add(new Group() {
                Id = 1,
                DateStart = start,
                DateEnd = end,
                GroupName = "17-67-0002",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Бояркина Е.В."
            });

            model.actualGroups.Add(new Group() {
                Id = 0,
                DateStart = start,
                DateEnd = end,
                GroupName = "17-67-0001",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Бояркина Е.В."
            });



            model.futureGroups.Add(new Group() {
                Id = 0,
                DateStart = start,
                DateEnd = end,
                GroupName = "17-67-0001",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Бояркина Е.В."
            });

            model.futureGroups.Add(new Group() {
                Id = 0,
                DateStart = start,
                DateEnd = end,
                GroupName = "17-67-0001",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Бояркина Е.В."
            });

            model.futureGroups.Add(new Group() {
                Id = 0,
                DateStart = start,
                DateEnd = end,
                GroupName = "17-67-0001",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Бояркина Е.В."
            });




            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = start,
                    DateEnd = end,
                    GroupName = "17-67-0001",
                    Area = "г. Тобольск, 9 мкр.",
                    Course = "Курс 1",
                    Lecturer = "Бояркина Е.В."
                },
                IsSuccess = true,
                Mark = "4"
            });

            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = start,
                    DateEnd = end,
                    GroupName = "17-67-0001",
                    Area = "г. Тобольск, 9 мкр.",
                    Course = "Курс 1",
                    Lecturer = "Бояркина Е.В."
                },
                IsSuccess = false,
                Mark = "2"
            });

            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = start,
                    DateEnd = end,
                    GroupName = "17-67-0001",
                    Area = "г. Тобольск, 9 мкр.",
                    Course = "Курс 1",
                    Lecturer = "Бояркина Е.В."
                },
                IsSuccess = false,
                Mark = "Пропуск занятия"
            });

            return View(model);
        }

        public ActionResult Planning() {
            PlanningModel model = new PlanningModel();
            model.BossFio = "Ткаченко Светлана Андреевна";
            model.ochnCourses = new List<LearningCourse>();

            model.ochnCourses.Add(new LearningCourse() {
                Id = 1,
                Name = "Корпоративная культура 1",
                IsRemote = false
            });

            model.ochnCourses.Add(new LearningCourse() {
                Id = 2,
                Name = "Корпоративная культура 2",
                IsRemote = false
            });

            model.ochnCourses.Add(new LearningCourse() {
                Id = 3,
                Name = "Дизайн мышление",
                IsRemote = false
            });

            model.distCourses.Add(new LearningCourse() {
                Id = 4,
                Name = "Обращение с подарками",
                IsRemote = true
            });

            model.distCourses.Add(new LearningCourse() {
                Id = 5,
                Name = "Проблемы при работе с кредитами",
                IsRemote = true
            });

            model.distCourses.Add(new LearningCourse() {
                Id = 6,
                Name = "Соло на клавиатуре",
                IsRemote = true
            });

            return View(model);
        }

    }
}