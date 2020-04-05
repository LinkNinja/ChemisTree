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

        private MySqlConnection conn;

        public DBConnection()
        {

        }

        public string ConnectToDB()
        {
            string retVal;
            string connStr = "server=" + this.server + ";user=" + this.username + ";database=" + this.database + ";port=" + this.port + ";password=" + this.password + ";";
            this.conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                retVal = "Connected.";
            }
            catch (Exception ex)
            {
                retVal = "Not connected. Error.";
            }

            return retVal;
        }

        public void CloseDB()
        {
            this.conn.Close();
        }

        public (List<Element>, string) GetDB()
        {
            List<Element> data = new List<Element>();
            string msg = "";

            string sql = "SELECT * FROM elements;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    data.Add(new Element(reader[3].ToString(), reader[1].ToString(), reader[2].ToString(), reader[4].ToString(), reader[5].ToString()));
                    msg = "Successfully queried DB.";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                msg = "Error reading from DB.";
            }

            return (data, msg);
        }

        public DataTable GetDBGrid()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM elements;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            return dt;
        }

        //This function will send a message to the database to request the information we want to query
        public void queryDB(string abbr)
        {
            Console.WriteLine(abbr);
            //Console.WriteLine("SELECT FROM ELEMENTS THE SPECIFIC ELEMENT THAT WAS SELECTED");
        }
    }







    class Element
    {
        public string atomicNumber;
        public string name;
        public string abbr;
        public string periodicGroup;
        public string periodicPeriod;

        public Element()
        {
            this.atomicNumber = "";
            this.name = "";
            this.abbr = "";
            this.periodicGroup = "";
            this.periodicPeriod = "";
        }

        public Element(string atomicNumber, string name, string abbr, string periodicGroup, string periodicPeriod)
        {
            this.atomicNumber = atomicNumber;
            this.name = name;
            this.abbr = abbr;
            this.periodicGroup = periodicGroup;
            this.periodicPeriod = periodicPeriod;
        }
    }
}
