using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace DemoDataAccessApplicationBlock
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            txtCustomers.Text = string.Empty;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString);
            SqlCommand cmd = new SqlCommand("GetCustomerList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtCustomers.Text += reader["CompanyName"] + " from " + reader["City"] + Environment.NewLine;
                }
                reader.Close();
            }
            finally
            {
                con.Close();
            }

        }

        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            txtCustomers.Text = string.Empty;//golesc textboxul de raportare

            //linia urmatoare poate fi executata o singura data, de exemplu apelata din Main
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());

            Database database = DatabaseFactory.CreateDatabase("myConStr");
            using (IDataReader reader = database.ExecuteReader(CommandType.StoredProcedure, "[GetCustomerList]"))
            {
                while (reader.Read())
                {
                    txtCustomers.Text += reader["CompanyName"] + " from " + reader["City"] + Environment.NewLine;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString);
            SqlCommand cmd = new SqlCommand("[AddCustomer]", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //prepare the three parameters
            SqlParameter paramId = new SqlParameter("@customerid", txtInsertId.Text);
            SqlParameter paramName = new SqlParameter("@CompanyName", txtInsertName.Text);
            SqlParameter paramCity = new SqlParameter("@City", txtInsertCity.Text);

            cmd.Parameters.Add(paramId);
            cmd.Parameters.Add(paramName);
            cmd.Parameters.Add(paramCity);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //linia urmatoare poate fi executata o singura data, de exemplu apelata din Main
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());

            Database database = DatabaseFactory.CreateDatabase("myConStr");
            database.ExecuteNonQuery("AddCustomer", txtInsertId.Text, txtInsertName.Text, txtInsertCity.Text);

            //cu o singura linie de cod:
            //DatabaseFactory.CreateDatabase("myConStr").ExecuteNonQuery("AddCustomer", txtInsertId.Text, txtInsertName.Text, txtInsertCity.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cboCustomers.Items.Clear();
            //linia urmatoare poate fi executata o singura data, de exemplu apelata din Main
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());

            Database database = DatabaseFactory.CreateDatabase("myConStr");
            using (IDataReader reader = database.ExecuteReader(CommandType.StoredProcedure, "[GetCustomerList]"))
            {
                while (reader.Read())
                {
                    cboCustomers.Items.Add(reader["CustomerID"]);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cboCustomers.SelectedItem == null)
            {
                return;
            }
            //linia urmatoare poate fi executata o singura data, de exemplu apelata din Main
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());

            Database database = DatabaseFactory.CreateDatabase("myConStr");
            //to make ExecuteNonQuery to return the real result, make sure that you 
            //remove the SET NOCOUNT ON form the stored procedure
            //"When SET NOCOUNT is ON, the count (indicating the number of rows affected by a Transact-SQL statement) is not returned."
            int rowsAffected = database.ExecuteNonQuery("[DeleteCustomer]", cboCustomers.SelectedItem.ToString());
            lblItemsDeleted.Text = rowsAffected.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //linia urmatoare poate fi executata o singura data, de exemplu apelata din Main
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());

            Database database = DatabaseFactory.CreateDatabase("myConStr");

            var howManyItemsUpdated = database.ExecuteNonQuery("[UpdateCustomer]", txtUpdateId.Text, txtUpdateName.Text);
            lblItemsUpdated.Text = howManyItemsUpdated.ToString();
        }
    }
}
