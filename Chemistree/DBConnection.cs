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

        public void queryDB(string abbr)
        {
            //Create element list using variable data.
            List<Element> data = new List<Element>();
            Element e = new Element();
            // Debug message.
            string msg = "";
            //query statement for database
            string query = "SELECT * FROM elements Where abbreviation ='" + abbr + "'";

            //Working on how to use a procedure to query the database making it more secure.
            string sql = "ProcedureName";


            try
            {

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                //Begin reading the database
                while (reader.Read())
                {
                    //By reading the table column name it prevents issues if more columns are added in the future.
                    data.Add(new Element(reader["atomicNumber"].ToString(), reader["name"].ToString(), reader["abbreviation"].ToString(), reader["periodicGroup"].ToString(), reader["periodicPeriod"].ToString()));

                    e.atomicNumber = reader["atomicNumber"].ToString();
                    e.name = reader["name"].ToString();
                    e.abbr = reader["abbreviation"].ToString();
                    e.periodicGroup = reader["periodicGroup"].ToString();
                    e.periodicPeriod = reader["periodicPeriod"].ToString();

                    msg = "Successfully queried DB.";

                }
                // Close the database.
                reader.Close();


            }
            catch (Exception ex)
            {
                msg = "Error reading from DB.";
            }


            //Testing if information was saved
            Console.WriteLine(msg);
            Console.WriteLine("This text excutued when element button is pressed");
            Console.WriteLine("Passed through queryDB() method displays");
            Console.WriteLine("Element Name: " + e.name);
            Console.WriteLine("Atomic Number: " + e.atomicNumber);
            Console.WriteLine("Abbreviation: " + e.abbr);
            Console.WriteLine("Periodic Group: " + e.periodicGroup);
            Console.WriteLine("Periodic Perioud: " + e.periodicPeriod);
            Console.WriteLine();


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
