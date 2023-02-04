using FootballFormApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballFormApp
{
    public partial class AdminForm : Form
    {
        FootballContext fc=new FootballContext();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dtgReserve.DataSource = fc.Reserves.ToList();
        }
    }
}
