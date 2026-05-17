using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace LoginForm
{//import statement. Note: make sure to add reference of MySql.Data.dll

    
    internal class MyDatabase
    {
//connection string. Note: change Database to your database name.

string connectionString = "Server=localhost;Port=3306;Database='borquillo_db';Uid='root';Pwd=''";



    //test connection method.

    //how to use:

    //           if (db.TestConnection())
    //           {
    //                MessageBox.Show("Connected to Database");
    //            }
    //            else
    //            {
    //               MessageBox.Show("Cannot Connected to Database");
    //            }



    public bool TestConnection()
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }









    //execute no return query method. used for queries; INSERT, UPDATE, DELETE

    public int ExecuteNoReturnQuery(string query, params MySqlParameter[] parameters)
    {
        int affectedRows = 0;
        using (MySqlConnection con = new MySqlConnection(connectionString))
        {
            MySqlCommand command = new MySqlCommand(query, con);
            if (parameters != null)
            {
                foreach (MySqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }

            }
            try
            {
                con.Open();
                affectedRows = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Execution failed: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return affectedRows;
        }
    }



    //execute return query. used for query SELECT.
    public DataTable ExecuteReturnQuery(string query, params MySqlParameter[] parameters)
    {
        using (MySqlConnection con = new MySqlConnection(connectionString))
        {
            MySqlCommand command = new MySqlCommand(query, con);
            if (parameters != null)
            {
                foreach (MySqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }
            DataTable dataTable = new DataTable();
            try
            {
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Execution failed: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }
    }
}
}
