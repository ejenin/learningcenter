using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Models.ViewModels.Catalogs.Shared {
    public class Area {
        public string Id { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
        public bool IsDeleted { get; set; }
    }
}