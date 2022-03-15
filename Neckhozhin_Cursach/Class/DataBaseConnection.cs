using Neckhozhin_Cursach.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckhozhin_Cursach.Class
{
    public class DataBaseConnection
    {
        public static Perfomance_ArtistEntities entities = new Perfomance_ArtistEntities();
        public static SqlConnection connect = null;

        public static void OpenConnection()
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-F0GRF9R\DUNGEONMASTER;Initial Catalog=Perfomance_Artist;" +
          "Integrated Security=SSPI;Pooling=False");
            connect.Open();
        }

        public static void CloseConnection()
        {
            connect.Close();
        }
        public static void SelectData(string sqlCommandText, DataTable data)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(sqlCommandText, connect);
            sqlCommand.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(data);
            CloseConnection();
        }
    }
}