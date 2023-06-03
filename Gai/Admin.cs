using Microsoft.Data.Sqlite;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gai
{
    public partial class Admin : Form
    {
        private String dbFileName;
        private SqliteConnection m_dbConn;
        private SqliteCommand m_sqlCmd;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            m_dbConn = new SqliteConnection();
            m_sqlCmd = new SqliteCommand();

            dbFileName = "client.db";
            lbStatusText.Text = "Disconnected";
        }

        private void ConnectionBT_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dbFileName))
                File.Create(dbFileName);

            try
            {
                m_dbConn = new SqliteConnection("Data source="+dbFileName);
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                //m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS clients (id INTEGER PRIMARY KEY AUTOINCREMENT,name TEXT, age INT, data Text, order_id INT, phone INT, parol TEXT)";
                //m_sqlCmd.ExecuteNonQuery();
                //m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS orders (order_id INT, hours INT, equipment_count INT, FOREIGN KEY(order_id) REFERENCES clients(order_id))";
                //m_sqlCmd.ExecuteNonQuery();

                lbStatusText.Text = "Connected";
            }
            catch (SqliteException ex)
            {
                lbStatusText.Text = "Disconnected";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
