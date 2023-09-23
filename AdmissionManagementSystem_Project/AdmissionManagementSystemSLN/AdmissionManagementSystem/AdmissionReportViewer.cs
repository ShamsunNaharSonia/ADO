using AdmissionManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace AdmissionManagementSystem
{
    public partial class AdmissionReportViewer : Form
    {
        List<FormViewModel> lst;
        public AdmissionReportViewer(List<FormViewModel> list)
        {
            InitializeComponent();
            lst = list;
        }

        private void AdmissionReportViewer_Load(object sender, EventArgs e)
        {
            AdmissionReport objRpt = new AdmissionReport();
            objRpt.SetDataSource(lst);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();

        }
    }
}
