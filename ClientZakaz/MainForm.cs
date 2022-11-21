using ClientZakaz.Models;

namespace ClientZakaz
{
    public partial class MainForm : Form
    {
        private BindingSource zakazi;
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
            //_bsCurrentUser = new BindingSource();
            //_bsCurrentUser.DataSource = new List<UserModel> { new UserModel(0) };
            //_textBoxUsername.DataBindings.Add("Text", _bsCurrentUser, nameof(UserModel.Username));
            //_textBoxPassword.DataBindings.Add("Text", _bsCurrentUser, nameof(UserModel.Password));
            //_checkBoxBan.DataBindings.Add("Checked", _bsCurrentUser, nameof(UserModel.Ban));
            //_textBoxSearch.DataBindings.Add("Text", _bsCurrentUser, nameof(UserModel.UsernameSearch));
        }

        public void Confirm_Click(object sender, EventArgs e)
        {
            zakazi.Add(new ZakazModel(0,null,textBoxProfession.Text,textBoxText.Text, Convert.ToInt32(textBoxPrice.Text),false, textBoxCity.Text,textBoxStreet.Text, textBoxFlat.Text));
        }
    }
}