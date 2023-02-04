namespace FootballFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            Menu mn=new Menu();
            mn.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm af=new AdminForm();
            af.ShowDialog();
        }
    }
}