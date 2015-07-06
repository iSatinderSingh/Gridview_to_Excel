using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gridview_to_excel
{
    public partial class WebForm1 : System.Web.UI.Page
    {
protected void Page_Load(object sender, EventArgs e)
{
    if (!Page.IsPostBack)
    {
        GridView1.DataSource = getData();
        GridView1.DataBind();
    }
}

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       
public DataTable getData()
{

    DataTable dt = new DataTable();
    dt.Columns.Add("UserId", typeof(Int32));
    dt.Columns.Add("UserName", typeof(string));
    dt.Columns.Add("Education", typeof(string));
    dt.Columns.Add("Location", typeof(string));
    dt.Rows.Add(1, "Satinder Singh", "Bsc Com Sci", "Mumbai");
    dt.Rows.Add(2, "Amit Sarna", "Mstr Com Sci", "Mumbai");
    dt.Rows.Add(3, "Andrea Ely", "Bsc Bio-Chemistry", "Queensland");
    dt.Rows.Add(4, "Leslie Mac", "MSC", "Town-ville");
    dt.Rows.Add(5, "Vaibhav Adhyapak", "MBA", "New Delhi");
    dt.Rows.Add(6, "Johny Dave", "MCA", "Texas");

    return dt;
}

public void GridviewToExcel()
{

    StringBuilder builder = new StringBuilder();
    string strFileName = "GridviewExcel_" + DateTime.Now.ToShortDateString() + ".csv";
    builder.Append("Name ,Education,Location" + Environment.NewLine);
    foreach (GridViewRow row in GridView1.Rows)
    {
        string name = row.Cells[0].Text;
        string education = row.Cells[1].Text;
        string location = row.Cells[2].Text;
        builder.Append(name + "," + education + "," + location + Environment.NewLine);
    }
    Response.Clear();
    Response.ContentType = "text/csv";
    Response.AddHeader("Content-Disposition", "attachment;filename=" + strFileName);
    Response.Write(builder.ToString());
    Response.End();
}

protected void Button1_Click1(object sender, EventArgs e)
{
    GridviewToExcel();
}

        protected void btn_2_Click(object sender, EventArgs e)
        {
           
        }

        public void ExportToExcel()
        {
            
        }

     }
}