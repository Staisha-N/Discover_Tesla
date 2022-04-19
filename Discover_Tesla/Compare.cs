using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Discover_Tesla
{
    public partial class Compare : Form
    {
        public Compare()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //connection object
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\cprrc\OneDrive\Desktop\Coding\SQLite 3\Discover Tesla\specs.db");
            con.Open();
            //command object
            
            if (((!rb1.Checked) && (!rb2.Checked) && (!rb3.Checked) && (!rb4.Checked)) || ((!rb5.Checked) && (!rb6.Checked) && (!rb7.Checked) && (!rb8.Checked)))
            {
                MessageBox.Show("Please select one model from each column.");
            }
            else if ((rb1.Checked && rb5.Checked) || (rb2.Checked && rb6.Checked) || (rb3.Checked && rb7.Checked) || (rb4.Checked && rb8.Checked))
            {
                MessageBox.Show("Please select 2 different models.");

            } else if ((rb1.Checked && rb6.Checked) || (rb2.Checked && rb5.Checked))
            {
                string query = "SELECT* FROM specs WHERE Model = 'S' OR Model = '3'";
                SQLiteCommand cmd = new SQLiteCommand(query, con);

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

            } else if ((rb1.Checked && rb7.Checked) || (rb3.Checked && rb5.Checked))
            {
                string query = "SELECT* FROM specs WHERE Model = 'S' OR Model = 'X'";
                SQLiteCommand cmd = new SQLiteCommand(query, con);

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            } else if ((rb1.Checked && rb8.Checked) || (rb4.Checked && rb5.Checked))
            {
                string query = "SELECT* FROM specs WHERE Model = 'S' OR Model = 'Y'";
                SQLiteCommand cmd = new SQLiteCommand(query, con);

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if ((rb2.Checked && rb7.Checked) || (rb3.Checked && rb6.Checked))
            {
                string query = "SELECT* FROM specs WHERE Model = '3' OR Model = 'X'";
                SQLiteCommand cmd = new SQLiteCommand(query, con);

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if ((rb2.Checked && rb8.Checked) || (rb4.Checked && rb6.Checked))
            {
                string query = "SELECT* FROM specs WHERE Model = '3' OR Model = 'Y'";
                SQLiteCommand cmd = new SQLiteCommand(query, con);

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else 
            {
                string query = "SELECT* FROM specs WHERE Model = 'X' OR Model = 'Y'";
                SQLiteCommand cmd = new SQLiteCommand(query, con);

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }








        }

    }
}
