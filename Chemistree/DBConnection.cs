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

/*
        //Main code to look at thats selecting the database
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
        */

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

        public void SubmitDB(Element e)
        {
            FormattableString sql = $"INSERT INTO elements (`name`, `abbrevation`, `atomicNumber`, `periodicGroup`, `periodicPeriod`) VALUES ({e.name}, {e.abbr}, {e.atomicNumber}, {e.periodicGroup}, {e.periodicPeriod});";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Rows affected: {0}", result);
            }
            catch (Exception ex)
            {
                // Handle Exception
            }
        }

        //This function will send a message to the database to request the information we want to query
        public void queryDB(string abbr)
        {
            //Creating a new list of Elements from the Elements object
            //variable is data
            List<Element> data = new List<Element>();
            Element e = new Element();

            //random msg
            string msg = "";

            //query statement for database
            string sql = "SELECT * FROM elements;";


            //using sql api 
            //MySqlCommand cmd = new MySqlCommand(sql, conn);

            // created a reader for the database
            //MySqlDataReader reader = cmd.ExecuteReader();

            //begins reading the records of the database
            //reader.Read();

            //The abbreviation will be used to pick out which element.
            //So if the s.txt = h then h = abbreviation from database.
            //abbreviation from database = 
            // name
            // abbreviation
            // atomicNumber
            // periodicGroup


            //data.add adds an object to the end of the list
            //Element(string atomicNumber, string name, string abbr, string periodicGroup, string periodicPeriod)

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    data.Add(new Element(reader[3].ToString(), reader[1].ToString(), reader[2].ToString(), reader[4].ToString(), reader[5].ToString()));


                    //if the abbreviation is equal to the abbrevation in the database.
                    //Create new element object and begin storing the element
                    // information into the list.
                    if (abbr == reader[2].ToString())
                    {


                        e.atomicNumber = reader[3].ToString(); //will set the objects atomic number by reading the database array space [3] and storing assigning to e.atomicNumber as a String
                        e.name = reader[1].ToString();// Set the object name by reading the database array space[1] it will assign whatever is in the space to the name.
                        e.abbr = reader[2].ToString();// Set the abbrevation of the element object by reading the database array space [2] and assinging its value
                        e.periodicGroup = reader[4].ToString(); // Set the periodic group
                        e.periodicPeriod = reader[5].ToString();// set the periodic period

                        msg = "Successfully queried DB.";
                    }
                }



                reader.Close();


            }
            catch (Exception ex)
            {
                msg = "Error reading from DB.";
            }

            //Use for loop to clean up.
            //Element e = new Element();
            //e.atomicNumber = reader[3].ToString();
            //e.name = reader[1].ToString();
            //e.abbr = reader[2].ToString();
            //e.periodicGroup = reader[4].ToString();
            //e.periodicPeriod = reader[5].ToString();



            //Testing if information was saved
            Console.WriteLine(msg);
            Console.WriteLine("This text excutued when element button is pressed");
            Console.WriteLine("Passed through queryDB() method displays \nElement Name: " + e.name);
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

