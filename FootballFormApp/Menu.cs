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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerForm wf=new WorkerForm();
            wf.ShowDialog();
        }

        private void stadiumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStadium asd=new AddStadium();
            asd.ShowDialog();
        }

        private void clientToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ClientDel cd=new ClientDel();
            cd.ShowDialog();
        }

        private void stadiumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StadiumDel sd=new StadiumDel();
            sd.ShowDialog();
        }
    }
}
