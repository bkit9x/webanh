using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace NguyenHoangKha
{
    public partial class load : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltrLoadHinhAnh.Text = LoadHinhAnh();
            }
        }
        private string LoadHinhAnh()
        {
            string connectionString =
                "Data Source=KIT;database=NguyenHoangKha;Initial Catalog=NguyenHoangKha;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = "SELECT TOP 12 link FROM dbo.hinhanh ORDER BY NEWID();";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                string s = "";
                while (reader.Read())
                {
                    s += @"<div class='col-lg-3 col-md-4 col-sm-6 col-xs-12 thumb'><a href='" + reader[0] + @"' class='fancybox' rel='ligthbox'><img src='" + reader[0] + @"' class='zoom img-fluid' alt='anh hot girl'></a></div>";
                }
                reader.Close();
                return s;
            }
        }
    }
}