using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testProject.Models.ViewModels;

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
                Header = "Заголовок информационной новости",
                Type = Models.ViewModels.Feed.NewsType.Information,
                ReaderId = 0
            });

            feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
                Id = 1,
                CreateDate = DateTime.Now,
                Text = "Пример позитивной новости",
                Header = "Заголовок позитивной новости",
                Type = Models.ViewModels.Feed.NewsType.Positive,
                ReaderId = 0
            });

            feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
                Id = 2,
                CreateDate = DateTime.Now,
                Text = "Пример негативной новости",
                Header = "Заголовок негативной новости",
                Type = Models.ViewModels.Feed.NewsType.Negative,
                ReaderId = 0
            });

            feed.newsToShow = feed.newsToShow.OrderByDescending(n => n.Id).ToList();

            return View(feed);
        }

    }
}