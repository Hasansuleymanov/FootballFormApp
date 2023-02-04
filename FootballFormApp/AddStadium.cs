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
    public partial class AddStadium : Form
    {
        FootballContext fc=new FootballContext();
        public AddStadium()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Stad=txtNewStadium.Text;
            int symbol = 0;
            foreach (Stadium item in fc.Stadiums)
            {
                if (item.Name.ToLower()== Stad.ToLower())
                {
                    symbol += 1;
                }
            }
            if (symbol == 0)
            {
                Stadium sd = new Stadium()
                {
                    Name = Stad
                };
                MessageBox.Show("Stadion yaradildi", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fc.Stadiums.Add(sd);
                fc.SaveChanges();
            }
            else
            {
                MessageBox.Show("Bele bir stadion artiq yaradilmisdir", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddStadium_Load(object sender, EventArgs e)
        {

        }
    }
}
