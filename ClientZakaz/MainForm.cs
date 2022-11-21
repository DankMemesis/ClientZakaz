using ClientZakaz.Models;

namespace ClientZakaz
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zakaz";

            //SetBindings();

            this.Load += MainForm_Load;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            List<ZakazModel> zakazi = new List<ZakazModel>();
            dataGridView1.DataSource = zakazi;
        }
    }
}