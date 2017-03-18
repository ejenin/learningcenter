using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testProject.Models.ViewModels.Feed;

namespace testProject.Models.ViewModels {
    public class FeedModel {

        public List<News> newsToShow;

        public FeedModel() {
            newsToShow = new List<News>();
        }
    }
}