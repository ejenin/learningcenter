using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject {
    public enum BidStatus {
        WaitingToConfirm = 0,
        SwappedByHands = 1,
        Rejected = 2,
        Confirmed = 3,
        PlannedByAutomate = -1
    }
}

namespace testProject.Models.ViewModels.Confirm {
    public class Bid {
        public string EmployeeFio { get; set; }
        public DateTime BidDate { get; set; }
        public string Course { get; set; }
        public DateTime LearningStart { get; set; }
        public DateTime LearningEnd { get; set; }
        public string Area { get; set; }
        public BidStatus Status { get; set; }
        public bool IsInWaitingList { get; set; }
    }
}