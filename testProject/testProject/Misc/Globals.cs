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
        public static Mode CurrentMode = Mode.ADMINISTRATOR;
        
        public static bool StringIsEmpty(string val) {
            return String.IsNullOrEmpty(val) || String.IsNullOrWhiteSpace(val);
        }

        public static int? GetSafeIntVal(string val) {
            int res = 0;
            if (StringIsEmpty(val) || !int.TryParse(val, out res)) {
                return null;
            }
            return res;
        }
    }
}