using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Dashboard : Form
    {
        public string UserName { get; set; }

        public string Password { get; set; }
        Visitors vis;
        public Dashboard()
        {
            InitializeComponent();
           // BindGrid();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string visitorsID = visitorsIDTB.Text;
                string name = nameTB.Text;
                string phoneno = phonenoTB.Text;
                string price = priceTB.Text;
                string agegroup = agegroupCB.SelectedItem.ToString();
                string duration = durationCB.SelectedItem.ToString();
                string groupno = groupnoCB.SelectedItem.ToString();
                string inhour = inhourCB.SelectedItem.ToString();
                string outhour = outhourCB.SelectedItem.ToString();
                string inminute = inminuteCB.SelectedItem.ToString();
                string outminute = outminuteCB.SelectedItem.ToString();
                string intime = intimeCB.SelectedItem.ToString();
                string outtime = outtimeCB.SelectedItem.ToString();
                string dateTime1 = dateTimePicker1.Value.Date.Year.ToString();
                string dateTime2 = dateTimePicker1.Value.Date.Month.ToString();
                string dateTime3 = dateTimePicker1.Value.Date.Day.ToString();
                string day = dateTimePicker1.Value.Date.DayOfWeek.ToString();
                string inTime = inhour +":"+ inminute + " " + intime;
                string outTime = outhour + ":" + outminute + " " + outtime;

                vis = new Visitors();
                vis.VisitorsID = visitorsID;
                vis.VisitorsName = name;
                vis.PhoneNo = phoneno;
                vis.Price = price;
                vis.AgeGroup = agegroup;
                vis.Duration = duration;
                vis.GroupNo = groupno;
                vis.InTime = inTime;
                vis.OutTime = outTime;
                vis.VisitorsDateTime = dateTime1 + "/" + dateTime2 + "/" + dateTime3;
                vis.Day = day;


                string data = Utility.ReadToText(); //GETTING DATA FROM TEXT FILE AND ASSINIGNG IN "data"
                List<Visitors> lstStudent = new List<Visitors>();
                if (data != null & data != "")
                {
                    lstStudent = JsonConvert.DeserializeObject<List<Visitors>>(data);
                }
                lstStudent.Add(vis);

                string str = JsonConvert.SerializeObject(lstStudent);

                Utility.WriteToText(str);

                //  MessageBox.Show("Visitors Record has been recorded");
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                
                DialogResult result = MessageBox.Show("Visitors record has been recorded", "Mesage", buttons);
                if (result == DialogResult.OK)
                {
                    //this.Close();
                    clearDetails();
                   
                }
                else
                {
                    // Do something  
                }

            }
            catch (Exception)
            {

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
          
        }

        private void clearDetails()
        {
            visitorsIDTB.Text = "";
            nameTB.Text = "";
            phonenoTB.Text = "";
            priceTB.Text = "";
            agegroupCB.SelectedItem = "--Select--";
            durationCB.SelectedItem = "--Select--";
            groupnoCB.SelectedItem = "--Select--";
            inhourCB.SelectedItem = "0";
            outhourCB.SelectedItem = "0";
            inminuteCB.SelectedItem = "00";
            outminuteCB.SelectedItem = "00";
            intimeCB.SelectedItem = "AM";
            outtimeCB.SelectedItem = "AM";
            dateTimePicker1.Value = DateTime.UtcNow;
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            reportChart rp = new reportChart();
            rp.ShowDialog();
        }

        private void visitorsIDTB_TextChanged(object sender, EventArgs e)
        {
            bhbudfhvu
        }
    }
}
