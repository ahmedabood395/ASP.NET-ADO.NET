using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LabDay3Asp
{
    public class instructorLayer
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
        public static DataTable GetallDept()
        {
            SqlCommand cmd = new SqlCommand("select * from department");
           return DBLrayer.select(cmd); 
        }
        public static DataTable GetallIns()
        {
            SqlCommand cmd = new SqlCommand("select * from instructor");
            return DBLrayer.select(cmd);
        }
        public static DataTable GetallInsById(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from instructor where dept_id=@id");
            cmd.Parameters.AddWithValue("id", id);
            return DBLrayer.select(cmd);
        }
        public static void AddIns(string name,string email,string pass,string cv,string photo,int age,int dept_id)
        {
            SqlCommand cmd = new SqlCommand("insertins");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("password", pass);
            cmd.Parameters.AddWithValue("cv", cv);
            cmd.Parameters.AddWithValue("photo", photo);
            cmd.Parameters.AddWithValue("age", age);
            cmd.Parameters.AddWithValue("dept_id", dept_id);
            DBLrayer.dml(cmd);
        }
        public static void UpdateIns(int id,string name, string email, string cv, string photo, int age, int dept_id)
        {
            SqlCommand cmd = new SqlCommand("update instructor set name=@name,email=@email,cv=@cv,photo=@photo,age=@age,dept_id=@dept_id where id=@id");
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("cv", cv);
            cmd.Parameters.AddWithValue("photo", photo);
            cmd.Parameters.AddWithValue("age", age);
            cmd.Parameters.AddWithValue("dept_id", dept_id);
            cmd.Parameters.AddWithValue("id", id);
            DBLrayer.dml(cmd);
        }
        public static void DeleteIns(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from instructor where id=@id");
            cmd.Parameters.AddWithValue("id", id);
            DBLrayer.dml(cmd);

        }
    }
}