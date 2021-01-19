using System;
using System.Data.SqlClient;

namespace NguyenHoangKha
{
    public partial class admin : System.Web.UI.Page
    {
        private string connectionString =
    "Data Source=KIT;database=NguyenHoangKha;Initial Catalog=NguyenHoangKha;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Form["button_Delete"] != null)
                {
                    string queryString = "DELETE FROM dbo.hinhanh WHERE id=@id;";
                    using (SqlConnection connection =
                        new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        command.Parameters.AddWithValue("@id", Request.Form["DeleteId"]);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                }
                if (Request.Form["button_edit"] != null)
                {
                    string queryString = "UPDATE dbo.hinhanh SET link=@link WHERE id=@id;";
                    using (SqlConnection connection =
                        new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        command.Parameters.AddWithValue("@id", Request.Form["EditId"]);
                        command.Parameters.AddWithValue("@link", Request.Form["EditLink"]);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                if (Request.Form["button_add"] != null)
                {
                    string queryString = "INSERT INTO dbo.hinhanh VALUES(@id,@link);";
                    using (SqlConnection connection =
                        new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        command.Parameters.AddWithValue("@id", Request.Form["AddId"]);
                        command.Parameters.AddWithValue("@link", Request.Form["AddLink"]);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                ltrTable.Text = LoadHinhAnh();
            }
        }
        private string LoadHinhAnh()
        {

            string queryString = "SELECT * FROM dbo.hinhanh;";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                string s = "";
                while (reader.Read())
                {
                    s += "<tr><th>" + reader[0] + @"</th><th>" + reader[1] + @"</th><th><img src='" + reader[1] + @"' class='small_thumb' alt='images'/></th><th><a href='#' class='btn btn-success ml-2' onclick='modalEdit(" + reader[0] + ",\"" + reader[1] + "\")'>Sửa</a> <a href='#' class='btn btn-danger ml-2' onclick='modalDelete(" + reader[0] + @")'>Xóa</a></th></tr>
";
                }
                reader.Close();
                return s;
            }
        }
    }
}