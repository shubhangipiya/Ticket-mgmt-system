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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid()
        {
            Visitors obj = new Visitors();
            List<Visitors> listReview = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listReview);
            dataGridViewAdmin.DataSource = dt;
            // BindChart(listReview);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
