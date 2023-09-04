using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios
{
    public partial class ex1A : Form
    {
        public ex1A()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        string[] teams = { "LAL", "LAC", "SAC", "GSW" };

        private void ex1A_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Team", typeof(string));
            dt.Columns.Add("Number", typeof(int));
            dg1.DataSource = dt;

            //if (dg1.Rows.Count == 1)
            //{
            //    MessageBox.Show("Empty DataSet, please insert entry!");
            //}

            foreach (var team in teams)
            {
                cb_teams.Items.Add(team);
            }
            cb_teams.SelectedIndex = 0;
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txt_name.Text, cb_teams.SelectedItem, number_player.Value);
            txt_name.Text = "";
            cb_teams.SelectedIndex = 0;
            number_player.Value = 0;
        }

        private void btn_showPlayer_Click(object sender, EventArgs e)
        {
            var details = new List<string>();
            try
            {
                for (int i = 0; i < dg1.Rows.Count; i++)
                {
                    if (dg1.Rows[i].Selected == true && dg1.Rows[i].Cells[0].Value != null)
                    {
                        for (int j = 0; j < dg1.Rows[i].Cells.Count; j++)
                        {
                            details.Add(dg1.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insert a player first!");
                    }
                }


                if (details.Count > 0 && dg1.Rows.Count > 1)
                {
                    MessageBox.Show($"Name: {details[0]}\n" +
                                    $"Team: {details[1]}\n" +
                                    $"Number:{details[2]}");
                }
                else
                {
                    MessageBox.Show("Please select a full row!");
                }
                details.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a full row!");
                throw;
            }


        }

        private void btn_deletePlayer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dg1.Rows.Count; i++)
            {
                if (dg1.Rows[i].Selected == true)
                {
                    dg1.Rows.RemoveAt(dg1.Rows[i].Index);
                    MessageBox.Show("Player deleted successfuly.");
                }
                else
                {
                    MessageBox.Show("Please select row to delete player.");
                }
            }
        }
    }
}
