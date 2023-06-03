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
    public partial class Client : Form
    {
        private String dbFileName;
        private SqliteConnection m_dbConn;
        private SqliteCommand m_sqlCmd;
        private int lastID;
        public Client()
        {
            InitializeComponent();
        }

        private void equipCB_CheckedChanged(object sender, EventArgs e)
        {
            equipcount.Visible = !equipcount.Visible;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            m_dbConn = new SqliteConnection();
            m_sqlCmd = new SqliteCommand();

            dbFileName = "client.db";
            lbStatusText.Text = "Disconnected";
            if (!File.Exists(dbFileName))
                File.Create(dbFileName);

            try
            {
                m_dbConn = new SqliteConnection("Data source=" + dbFileName);
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

               // m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS clients (id INTEGER PRIMARY KEY AUTOINCREMENT,name TEXT, age INT, data Text,days INT, equipment INT, sklon TEXT)";
                //m_sqlCmd.ExecuteNonQuery();

                lbStatusText.Text = "Connected";
            }
            catch (SqliteException ex)
            {
                lbStatusText.Text = "Disconnected";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            AgeTB.Clear();
            nameTB.Clear();
            equipCB.Checked = false;
            DayscountNUD.Value = 0;
            equipcount.Value = 0;
            equipcount.Visible = false;
            DateCT.Value = DateTime.Today;
            SklonKB.SelectedIndex=-1;
        }

        private void ApplyBT_Click(object sender, EventArgs e)
        {
            if (m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return;
            }
            try
            {
                m_sqlCmd.CommandText = "INSERT INTO clients ('name', 'age', 'data','days','equipment', 'sklon') values ('"+
                    nameTB.Text + "', '"+
                    AgeTB.Text+"','"+
                    DateCT.Text+"','"+
                    DayscountNUD.Value + "','" +
                    equipcount.Value+"','" +
                    SklonKB.Text+"')";
                m_sqlCmd.ExecuteNonQuery();
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
