using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace project_cuoiKy
{
    public class function
    {
        protected SqlConnection getConnection()
        {
            string str = @"Data Source=VONHUY\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=VONHUY\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();



        }
    }
}
