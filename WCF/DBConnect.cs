using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;
using System.Windows.Forms;

namespace WCF
{
    
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        
        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        public void Initialize()
        {
            server = "localhost";
            database = "impresora";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        return false;
                     

                    case 1045:
                        return false;
                       
                }
                return false;
            }
        }


        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
              
                return false;
            }
        }

        public List<string>[] Select()
        {
            string query = "SELECT * FROM orden";

            //Create a list to store the result
            List<string>[] list = new List<string>[7];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["codOrden"] + "");
                    list[1].Add(dataReader["codCentro"] + "");
                    list[2].Add(dataReader["codRecurso"] + "");
                    list[3].Add(dataReader["producto"] + "");
                    list[4].Add(dataReader["CodProducto"] + "");

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                MessageBox.Show("No se pudo conectar");
                return list;
            }
        }
        //Insert statement
        public string Insert()
        {
            return "ff";
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

      
    }
}