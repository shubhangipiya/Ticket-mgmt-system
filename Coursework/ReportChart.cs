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
    public partial class reportChart : Form
    {
        public reportChart()
        {
            InitializeComponent();
            loadChart();
        }
        
        private void loadChart()
        {
            string data1 = Utility.ReadToText();
            List<Visitors> lstStudent = JsonConvert.DeserializeObject<List<Visitors>>(data1);
            var groupdata = lstStudent
                    .GroupBy(l => l.Day)
                    .Select(cl => new
                    {
                        VisitorsID = cl.First().VisitorsID,
                    //  Sum = cl.Sum(),
                        Count = cl.Count().ToString()
                    }).ToList();
            reportCHT.Series[0].LegendText = "Visitors Graph";
            reportCHT.Series[1].LegendText = "Earning Graph";
            reportCHT.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            reportCHT.Series[0].IsValueShownAsLabel = true;
            reportCHT.Series[0].XValueMember = "VisitorsID";
            reportCHT.Series[0].YValueMembers = "Count";
            reportCHT.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            reportCHT.Series[1].IsValueShownAsLabel = true;
            reportCHT.Series[1].XValueMember = "Price";
            reportCHT.Series[1].YValueMembers = "Count";
            reportCHT.DataSource = groupdata;

/* var groupdata1= lstStudent.GroupBy(m => m.Day)
                .Select(m => new
                {
                    VisitorsID = m.Key,
                  //Price = m.All()
                    Count = m.Count()
                });
            reportCHT.Series[0].LegendText = "Visitors Graph";
            reportCHT.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            reportCHT.Series[0].IsValueShownAsLabel = true;
            reportCHT.Series[0].XValueMember = "VisitorsID";
            reportCHT.Series[0].YValueMembers = "Count";
            reportCHT.DataSource = groupdata1;

*/


        }
    }
}
