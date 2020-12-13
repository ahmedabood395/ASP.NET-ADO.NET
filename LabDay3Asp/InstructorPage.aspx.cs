using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LabDay3Asp
{
    public partial class InstructorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt=instructorLayer.GetallDept();
                drpd_id_dept.DataSource = dt;
                drpd_id_dept.DataTextField = "name";
                drpd_id_dept.DataValueField = "id";
                drpd_id_dept.DataBind();

                DataTable dt2 = instructorLayer.GetallDept();
                drp_name_dept.DataSource = dt2;
                drp_name_dept.DataTextField = "name";
                drp_name_dept.DataValueField = "id";
                drp_name_dept.DataBind();

                DataTable dt3 = instructorLayer.GetallIns();
                drp_name_ins.DataSource = dt3;
                drp_name_ins.DataTextField = "name";
                drp_name_ins.DataValueField = "id";
                drp_name_ins.DataBind();

                GridView1.DataSource = instructorLayer.GetallInsById(int.Parse(drpd_id_dept.SelectedValue));
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void drpd_id_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = instructorLayer.GetallInsById(int.Parse(drpd_id_dept.SelectedValue));
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            string pathcv = $"~/files/{fup_cv.FileName}";
            string pathimg = $"~/images/{fup_photo.FileName}";

            fup_cv.SaveAs(Server.MapPath(pathcv));
            fup_photo.SaveAs(Server.MapPath(pathimg));

            instructorLayer.AddIns(txt_name.Text, txt_email.Text, txt_pass.Text, pathcv, pathimg, int.Parse(txt_age.Text), int.Parse(drp_name_dept.SelectedValue));
            GridView1.DataSource = instructorLayer.GetallInsById(int.Parse(drpd_id_dept.SelectedValue));
            GridView1.DataBind();
            txt_age.Text = txt_email.Text = txt_name.Text = "";

            DataTable dt3 = instructorLayer.GetallIns();
            drp_name_ins.DataSource = dt3;
            drp_name_ins.DataTextField = "name";
            drp_name_ins.DataValueField = "id";
            drp_name_ins.DataBind();

        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            string pathcv = $"~/files/{fup_cv.FileName}";
            string pathimg = $"~/images/{fup_photo.FileName}";

            fup_cv.SaveAs(Server.MapPath(pathcv));
            fup_photo.SaveAs(Server.MapPath(pathimg));


            instructorLayer.UpdateIns(int.Parse(drp_name_ins.Text), txt_name.Text, txt_email.Text, pathcv, pathimg, int.Parse(txt_age.Text), int.Parse(drp_name_dept.SelectedValue));
            GridView1.DataSource = instructorLayer.GetallInsById(int.Parse(drpd_id_dept.SelectedValue));
            GridView1.DataBind();
            txt_age.Text = txt_email.Text = txt_name.Text = "";

            DataTable dt3 = instructorLayer.GetallIns();
            drp_name_ins.DataSource = dt3;
            drp_name_ins.DataTextField = "name";
            drp_name_ins.DataValueField = "id";
            drp_name_ins.DataBind();

        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            instructorLayer.DeleteIns(int.Parse(drp_name_ins.SelectedValue));
            GridView1.DataSource = instructorLayer.GetallInsById(int.Parse(drpd_id_dept.SelectedValue));
            GridView1.DataBind();
            txt_age.Text = txt_email.Text = txt_name.Text = "";

            DataTable dt3 = instructorLayer.GetallIns();
            drp_name_ins.DataSource = dt3;
            drp_name_ins.DataTextField = "name";
            drp_name_ins.DataValueField = "id";
            drp_name_ins.DataBind();

        }
    }
}