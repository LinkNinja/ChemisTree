using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

using System.Data;

namespace Chemistree_GUI_V1
{
    class DBConnection
    {
        // Database Credentials
        // username: Pnf2SBF448
        // password: lX19QKJIkA
        // server: remotemysql.com
        // database: Pnf2SBF448
        // port: 3306

        private string username = "Pnf2SBF448";
        private string password = "lX19QKJIkA";
        private string server = "remotemysql.com";
        private string database = "Pnf2SBF448";
        private int port = 3306;
        public Element e = new Element();
        private MySqlConnection conn;

        public DBConnection()
        {

        }

        public bool ConnectToDB()
        {
            bool result = false;
            string connStr = $"server={this.server};user={this.username};database={this.database};port={this.port};password={this.password};";
            //string connStr = "server=" + this.server + ";user=" + this.username + ";database=" + this.database + ";port=" + this.port + ";password=" + this.password + ";";
            this.conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                result = true;
            }
            catch (Exception ex)
            {
                // Handle Exception
            }
            return result;
        }

        public void CloseDB()
        {
            this.conn.Close();
        }

        public bool SubmitDB(Element e)
        {
            bool result = false;
            FormattableString sql = $"INSERT INTO elements VALUES ('{e.abbr}', '{e.name}', '{e.atomicNumber}', '{e.periodicGroup}', '{e.periodicPeriod}', '{e.electronConfiguration}');";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                result = (rowsAffected > 0) ? true : false; 
            }
            catch (Exception ex)
            {
                // Better handle exception
            }
            return result;
        }

        public (bool, Element) queryDB(string abbr)
        {
            bool result = false;
            Element e = new Element();
            //query statement for database
            string query = $"SELECT * FROM elements WHERE abbreviation = '{abbr}';";
            //Working on how to use a procedure to query the database making it more secure.
            string sql = "ProcedureName";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                //Begin reading the database
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //By reading the table column name it prevents issues if more columns are added in the future.
                        e.abbr = reader["abbreviation"].ToString();
                        e.name = reader["name"].ToString();
                        e.atomicNumber = reader["atomicNumber"].ToString();
                        e.periodicGroup = reader["periodicGroup"].ToString();
                        e.periodicPeriod = reader["periodicPeriod"].ToString();
                        e.electronConfiguration = reader["electronConfiguration"].ToString();
                    }
                    result = true;
                }
                // Close the database.
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle Exception
            }
            return (result, e);
        }
    }

    class Element
    {
        public string abbr;
        public string name;
        public string atomicNumber;
        public string periodicGroup;
        public string periodicPeriod;
        public string electronConfiguration;

        public Element()
        {
            this.abbr = "";
            this.name = "";
            this.atomicNumber = "";
            this.periodicGroup = "";
            this.periodicPeriod = "";
            this.electronConfiguration = "";
        }

        public Element(string abbr, string name, string atomicNumber, string periodicGroup, string periodicPeriod, string electronConfiguration)
        {
            this.abbr = abbr;
            this.name = name;
            this.atomicNumber = atomicNumber;
            this.periodicGroup = periodicGroup;
            this.periodicPeriod = periodicPeriod;
            this.electronConfiguration = electronConfiguration;
        }
    }
}
