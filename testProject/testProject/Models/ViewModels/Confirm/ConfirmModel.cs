using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Models.ViewModels.Confirm {
    public class ConfirmModel {

        public List<Bid> Bids { get; set; }
        public List<Bid> WaitingBids { get; set; }

        public ConfirmModel() {
            Bids = new List<Bid>();
            WaitingBids = new List<Bid>();
        }
    }
}