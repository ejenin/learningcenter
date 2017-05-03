using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace testProject.Misc {
    public static class DbMess {
        private static string CONNECTION_STRING = "Server=EUGENE-ПК;Database=LearningCenterTest;Integrated Security=true;";

        //TODO: Открывать и закрывать подключение руками

        public static string GetValue(string query) {
            var table = GetTable(query);
            if (table.Rows.Count == 0)
                return null;
            return table.Rows[0][0].ToString();
        }

        public static DataTable GetTable(string query) {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            conn.Open();
            DataTable res = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(res);
            conn.Close();
            return res;
        }

        public static void DoAction(string query) {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}