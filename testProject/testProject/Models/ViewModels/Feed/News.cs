using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Models.ViewModels.Feed {
    public enum NewsType {
        Information = 0,
        Positive = 1,
        Negative = 2
    }

    public enum InformationType {

    }

    public class News {
        public int Id { get; set; }

        /// <summary>
        /// Сотрудник, которому эта новость предназначается (а нужно ли вообще это поле?)
        /// </summary>
        public int ReaderId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ReadDate { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public NewsType Type { get; set; }
        public InformationType InfoType { get; set; }

        public string getCssClass() {
            return Type.ToString() + (ReadDate.HasValue ? "_Readed" : "");
        }
    }
}