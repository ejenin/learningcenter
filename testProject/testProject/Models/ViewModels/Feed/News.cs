using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Models.ViewModels.Feed {
    public enum NewsType {
        Information = 0,
        Positive,
        Negative
    }
    public class News {
        public int Id { get; set; }
        public int ReaderId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ReadDate { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public NewsType Type { get; set; }
    }
}