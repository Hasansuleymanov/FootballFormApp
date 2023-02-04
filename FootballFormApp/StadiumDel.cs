using FootballFormApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FootballFormApp
{
    public partial class StadiumDel : Form
    {
        FootballContext fc=new FootballContext();
        BindingList<Stadium> st1;
        int StadId;
        public StadiumDel()
        {
            InitializeComponent();
        }
        private void StadiumDel_Load(object sender, EventArgs e)
        {
            st1= new BindingList<Stadium>();
            foreach(Stadium st in fc.Stadiums)
            {
                st1.Add(st);
            }
            dtgStadium.DataSource = st1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedCount = dtgStadium.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedCount > 0)
            {
                for (int i = 0; i < selectedCount; i++)
                {
                    StadId = (int)dtgStadium.SelectedRows[0].Cells[0].Value;
                    dtgStadium.Rows.RemoveAt(dtgStadium.SelectedRows[0].Index);
                    Stadium stadium = fc.Stadiums.Find(StadId);
                    if (stadium != null)
                    {
                        fc.Stadiums.Remove(stadium);
                        fc.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("salam");
                    }
                }
            }
        }
    }
}
