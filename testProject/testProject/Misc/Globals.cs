using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject {
    public enum Mode {
        STUDENT,
        BOSS,
        ADMINISTRATOR
    }
}

namespace testProject.Misc {
    public static class Globals {
        public static Mode CurrentMode = Mode.BOSS;
        
        public static bool StringIsEmpty(string val) {
            return String.IsNullOrEmpty(val) || String.IsNullOrWhiteSpace(val);
        }
    }
}