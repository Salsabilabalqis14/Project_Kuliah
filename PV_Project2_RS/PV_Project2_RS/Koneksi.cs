using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PV_Project2_RS
{
	class Koneksi
	{
		public SqlConnection GetConn(){
			SqlConnection Conn = new SqlConnection();
			Conn.ConnectionString = "Data Source=LAPTOP-622UOQQQ; initial catalog=Rumah_sakit; integrated security=true";
			return Conn;
		}
	}
}
