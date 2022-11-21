namespace ClientZakaz
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxProfession = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxFlat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnProfession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.zakazModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProfession
            // 
            this.textBoxProfession.Location = new System.Drawing.Point(110, 38);
            this.textBoxProfession.Name = "textBoxProfession";
            this.textBoxProfession.Size = new System.Drawing.Size(177, 23);
            this.textBoxProfession.TabIndex = 0;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(166, 79);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(177, 114);
            this.textBoxText.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(166, 199);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(87, 23);
            this.textBoxPrice.TabIndex = 2;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(166, 269);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(103, 23);
            this.textBoxCity.TabIndex = 3;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(166, 298);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(177, 23);
            this.textBoxStreet.TabIndex = 4;
            // 
            // textBoxFlat
            // 
            this.textBoxFlat.Location = new System.Drawing.Point(166, 327);
            this.textBoxFlat.Name = "textBoxFlat";
            this.textBoxFlat.Size = new System.Drawing.Size(87, 23);
            this.textBoxFlat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Специалист";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Текст заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Город";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Улица";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Квартира";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(56, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 143);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Адрес";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxProfession);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(56, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 229);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заказ";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(56, 405);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(133, 23);
            this.Confirm.TabIndex = 14;
            this.Confirm.Text = "Сформировать заказ";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnId,
            this._columnUsername,
            this._columnProfession,
            this._columnText,
            this._columnPrice,
            this._columnCity,
            this._columnStreet,
            this._columnFlat,
            this._columnIsActive});
            this.dataGridView1.DataSource = this.zakazModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(357, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(431, 416);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // _columnId
            // 
            this._columnId.DataPropertyName = "Id";
            this._columnId.HeaderText = "Id";
            this._columnId.Name = "_columnId";
            this._columnId.ReadOnly = true;
            // 
            // _columnUsername
            // 
            this._columnUsername.DataPropertyName = "Username";
            this._columnUsername.HeaderText = "Username";
            this._columnUsername.Name = "_columnUsername";
            this._columnUsername.ReadOnly = true;
            // 
            // _columnProfession
            // 
            this._columnProfession.DataPropertyName = "Profession";
            this._columnProfession.HeaderText = "Profession";
            this._columnProfession.Name = "_columnProfession";
            this._columnProfession.ReadOnly = true;
            // 
            // _columnText
            // 
            this._columnText.DataPropertyName = "Text";
            this._columnText.HeaderText = "Text";
            this._columnText.Name = "_columnText";
            this._columnText.ReadOnly = true;
            // 
            // _columnPrice
            // 
            this._columnPrice.DataPropertyName = "Price";
            this._columnPrice.HeaderText = "Price";
            this._columnPrice.Name = "_columnPrice";
            this._columnPrice.ReadOnly = true;
            // 
            // _columnCity
            // 
            this._columnCity.DataPropertyName = "City";
            this._columnCity.HeaderText = "City";
            this._columnCity.Name = "_columnCity";
            this._columnCity.ReadOnly = true;
            // 
            // _columnStreet
            // 
            this._columnStreet.DataPropertyName = "Street";
            this._columnStreet.HeaderText = "Street";
            this._columnStreet.Name = "_columnStreet";
            this._columnStreet.ReadOnly = true;
            // 
            // _columnFlat
            // 
            this._columnFlat.DataPropertyName = "Flat";
            this._columnFlat.HeaderText = "Flat";
            this._columnFlat.Name = "_columnFlat";
            this._columnFlat.ReadOnly = true;
            // 
            // _columnIsActive
            // 
            this._columnIsActive.DataPropertyName = "IsActive";
            this._columnIsActive.HeaderText = "IsActive";
            this._columnIsActive.Name = "_columnIsActive";
            this._columnIsActive.ReadOnly = true;
            // 
            // zakazModelBindingSource
            // 
            this.zakazModelBindingSource.DataSource = typeof(ClientZakaz.Models.ZakazModel);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(195, 405);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 16;
            this.Previous.Text = "Пред.";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(276, 405);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 17;
            this.Next.Text = "След.";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFlat);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxProfession;
        private TextBox textBoxText;
        private TextBox textBoxPrice;
        private TextBox textBoxCity;
        private TextBox textBoxStreet;
        private TextBox textBoxFlat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button Confirm;
        private DataGridView dataGridView1;
        private BindingSource zakazModelBindingSource;
        private DataGridViewTextBoxColumn _columnId;
        private DataGridViewTextBoxColumn _columnUsername;
        private DataGridViewTextBoxColumn _columnProfession;
        private DataGridViewTextBoxColumn _columnText;
        private DataGridViewTextBoxColumn _columnPrice;
        private DataGridViewTextBoxColumn _columnCity;
        private DataGridViewTextBoxColumn _columnStreet;
        private DataGridViewTextBoxColumn _columnFlat;
        private DataGridViewCheckBoxColumn _columnIsActive;
        private Button Previous;
        private Button Next;
    }
}