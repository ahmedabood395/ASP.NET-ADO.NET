using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LabDay3Asp
{
    public class DBLrayer
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
        public static DataTable select(SqlCommand cmd)
        {
            cmd.Connection = con;
            SqlDataAdapter dpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dpt.Fill(dt);
            return dt;
        }
        public static int dml(SqlCommand cmd)
        {
            cmd.Connection = con;
            con.Open();
            int effect = cmd.ExecuteNonQuery();
            con.Close();
            return effect;
            
        }
    }
}