using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DatabaseService
    {

        public const string conStr = "Data Source=DESKTOP-OJM2OE8;Initial Catalog=UserManage;Integrated Security=True";
        SqlConnection con;
        public SqlCommand command;

        public DatabaseService()
        {
            con = new SqlConnection(conStr);
        }

        public void openConnection()
        {
            if(con != null && con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }


        public void closeConnection()
        {
            if(con != null && con.State == System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
        }


        //hàm doc data tu sql database tra ve su lieu chua trong sqldatareader
        public SqlDataReader ReadData(string sql)
        {
            //khoi tao comand
            command = new SqlCommand();

            command.CommandType = System.Data.CommandType.Text; 
            //truyen cau truy van 
            command.CommandText = sql;
            //truyen connecttion vao
            command.Connection = con;
            openConnection();
            SqlDataReader reader = command.ExecuteReader();
            return reader;

        }

        public SqlDataReader ReadDataPars(string sql, SqlParameter[] pars)
        {
            //khoi tao comand
            command = new SqlCommand();

            command.CommandType = System.Data.CommandType.Text;
            //truyen cau truy van 
            command.CommandText = sql;
            //truyen connecttion vao
            command.Connection = con;
            openConnection();
            command.Parameters.AddRange(pars);
            SqlDataReader reader = command.ExecuteReader();
            return reader;

        }

        public bool writeDataPars(string sql, SqlParameter[] pars)
        {
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            command.Connection = con;
            openConnection();
            command.Parameters.AddRange(pars);
            if(command.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
