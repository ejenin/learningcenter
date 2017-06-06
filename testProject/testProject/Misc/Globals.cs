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

        private static Random rnd = new Random();
        private static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
        
        public static bool StringIsEmpty(string val) {
            return String.IsNullOrEmpty(val) || String.IsNullOrWhiteSpace(val) || val == "-";
        }

        public static int? GetSafeIntVal(string val) {
            int res = 0;
            if (StringIsEmpty(val) || !int.TryParse(val, out res)) {
                return null;
            }
            return res;
        }

        public static string GetRandomName(int length) {
            string res = "";
            for (int i = 0; i < length; i++) {
                int index = rnd.Next(0, alphabet.Length);
                res += alphabet[index];
            }
            return res;
        }

        public static string DEFAULT_AVATAR = "/files/default/deafult_avatar.png";
    }
}