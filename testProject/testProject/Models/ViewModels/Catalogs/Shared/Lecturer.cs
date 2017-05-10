using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Models.ViewModels.Catalogs.Shared {
    public class Lecturer {
        public int Id { get; set; }
        public string FIO { get; set; }

        public int? OrganizationId { get; set; }
        public string OrganizationName { get; set; }

        public int? FileId { get; set; }
        public string FilePath { get; set; }

        public string Email { get; set; }
        public string ContactPhone { get; set; }
    }
}

/*
 *             <th>ID</th>
            <th>ФИО</th>
            <th>Организация</th>
            <th>Email</th>
            <th>Телефон</th>
            <th>Действие</th>
*/