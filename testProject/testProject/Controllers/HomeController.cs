using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testProject.Models.ViewModels;
using testProject.Models.ViewModels.MyGroups;

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

        public ActionResult MyGroups() {
            MyGroupsModel model = new MyGroupsModel();

            model.groups.Add(new Group() {
                Id = 3,
                DateStart = DateTime.Now,
                DateEnd = DateTime.Now,
                GroupName = "17-67-0004",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1"
            });

            model.groups.Add(new Group() {
                Id = 2,
                DateStart = DateTime.Now,
                DateEnd = DateTime.Now,
                GroupName = "17-67-0003",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1"
            });

            model.groups.Add(new Group() {
                Id = 1,
                DateStart = DateTime.Now,
                DateEnd = DateTime.Now,
                GroupName = "17-67-0002",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1"
            });

            model.groups.Add(new Group() {
                Id = 0,
                DateStart = DateTime.Now,
                DateEnd = DateTime.Now,
                GroupName = "17-67-0001",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1"
            });

            return View(model);
        }

    }
}