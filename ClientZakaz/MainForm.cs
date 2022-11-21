using ClientZakaz.Models;

namespace ClientZakaz
{
    public partial class MainForm : Form
    {
        private BindingSource zakazi;
        private BindingSource currentzakazi;
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zakaz";

            SetBindings();

            //this.Load += MainForm_Load;
        }
        public void MainForm_Load(object sender, EventArgs e) {
            LoadData();
        }
        private async void LoadData()
        {

        }
        private void SetBindings()
        {
            zakazi = new BindingSource();
            dataGridView1.DataSource = typeof(List<ZakazModel>);
            //привязки для DGV
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = zakazi;
            //привязки у столбцов
            _columnId.DataPropertyName = nameof(ZakazModel.Id);
            _columnUsername.DataPropertyName = nameof(ZakazModel.Username);
            _columnProfession.DataPropertyName = nameof(ZakazModel.Profession);
            _columnText.DataPropertyName = nameof(ZakazModel.Text);
            _columnPrice.DataPropertyName = nameof(ZakazModel.Price);
            _columnCity.DataPropertyName = nameof(ZakazModel.City);
            _columnStreet.DataPropertyName = nameof(ZakazModel.Street);
            _columnFlat.DataPropertyName = nameof(ZakazModel.Flat);
            _columnIsActive.DataPropertyName = nameof(ZakazModel.IsActive);

            //текстбоксы
            currentzakazi = new BindingSource();
            currentzakazi.DataSource = new List<ZakazModel> { new ZakazModel(0) };
            textBoxProfession.DataBindings.Add("Text", currentzakazi, nameof(ZakazModel.Profession));
            textBoxText.DataBindings.Add("Text", currentzakazi, nameof(ZakazModel.Text));
            textBoxPrice.DataBindings.Add("Text", currentzakazi, nameof(ZakazModel.Price));
            textBoxCity.DataBindings.Add("Text", currentzakazi, nameof(ZakazModel.City));
            textBoxStreet.DataBindings.Add("Text", currentzakazi, nameof(ZakazModel.Street));
            textBoxFlat.DataBindings.Add("Text", currentzakazi, nameof(ZakazModel.Flat));
        }
        private void SetCurrent()
        {
            if (zakazi.Count > 0)
            {
                currentzakazi.List[0] = ZakazModel.GetClone((ZakazModel)zakazi.Current);

            }
            else
            {
                currentzakazi.List[0] = new ZakazModel(0);
            }

            currentzakazi.ResetItem(0);
        }
        public void Confirm_Click(object sender, EventArgs e)
        {
            zakazi.Add(new ZakazModel(0,null,textBoxProfession.Text,textBoxText.Text, Convert.ToInt32(textBoxPrice.Text),false, textBoxCity.Text,textBoxStreet.Text, textBoxFlat.Text));
            SetCurrent();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            zakazi.MovePrevious();
            SetCurrent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            zakazi.MoveNext();
            SetCurrent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetCurrent();
        }
    }
}