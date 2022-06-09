using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace UAS_PV_No4
{
	class Koneksi
	{
		public SqlConnection GetConn(){
			SqlConnection Conn = new SqlConnection();
			Conn.ConnectionString = "Data Source=LAPTOP-622UOQQQ; initial catalog=Restauran; integrated security=true";
			return Conn;
		}
	}
}
