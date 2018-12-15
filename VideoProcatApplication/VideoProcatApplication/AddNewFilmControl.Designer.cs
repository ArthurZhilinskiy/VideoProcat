namespace VideoProcatApplication
{
    partial class AddNewFilmControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.mtbDescryption = new MetroFramework.Controls.MetroTextBox();
            this.mtbName = new MetroFramework.Controls.MetroTextBox();
            this.mtbTreyler = new MetroFramework.Controls.MetroTextBox();
            this.mtbImage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtbYear = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.Controls.Add(this.mtbDescryption);
            this.metroPanel1.Controls.Add(this.mtbYear);
            this.metroPanel1.Controls.Add(this.mtbName);
            this.metroPanel1.Controls.Add(this.mtbTreyler);
            this.metroPanel1.Controls.Add(this.mtbImage);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(690, 300);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Премьера",
            "Фильм",
            "Мультфильм",
            "Сериал"});
            this.metroComboBox1.Location = new System.Drawing.Point(141, 95);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(148, 29);
            this.metroComboBox1.TabIndex = 6;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            // 
            // mtbDescryption
            // 
            // 
            // 
            // 
            this.mtbDescryption.CustomButton.Image = null;
            this.mtbDescryption.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.mtbDescryption.CustomButton.Name = "";
            this.mtbDescryption.CustomButton.Size = new System.Drawing.Size(169, 169);
            this.mtbDescryption.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDescryption.CustomButton.TabIndex = 1;
            this.mtbDescryption.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDescryption.CustomButton.UseSelectable = true;
            this.mtbDescryption.CustomButton.Visible = false;
            this.mtbDescryption.Lines = new string[0];
            this.mtbDescryption.Location = new System.Drawing.Point(369, 47);
            this.mtbDescryption.MaxLength = 32767;
            this.mtbDescryption.Multiline = true;
            this.mtbDescryption.Name = "mtbDescryption";
            this.mtbDescryption.PasswordChar = '\0';
            this.mtbDescryption.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbDescryption.SelectedText = "";
            this.mtbDescryption.SelectionLength = 0;
            this.mtbDescryption.SelectionStart = 0;
            this.mtbDescryption.ShortcutsEnabled = true;
            this.mtbDescryption.Size = new System.Drawing.Size(292, 174);
            this.mtbDescryption.TabIndex = 5;
            this.mtbDescryption.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbDescryption.UseSelectable = true;
            this.mtbDescryption.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDescryption.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbName
            // 
            // 
            // 
            // 
            this.mtbName.CustomButton.Image = null;
            this.mtbName.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.mtbName.CustomButton.Name = "";
            this.mtbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbName.CustomButton.TabIndex = 1;
            this.mtbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbName.CustomButton.UseSelectable = true;
            this.mtbName.CustomButton.Visible = false;
            this.mtbName.Lines = new string[0];
            this.mtbName.Location = new System.Drawing.Point(141, 47);
            this.mtbName.MaxLength = 32767;
            this.mtbName.Name = "mtbName";
            this.mtbName.PasswordChar = '\0';
            this.mtbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbName.SelectedText = "";
            this.mtbName.SelectionLength = 0;
            this.mtbName.SelectionStart = 0;
            this.mtbName.ShortcutsEnabled = true;
            this.mtbName.Size = new System.Drawing.Size(148, 23);
            this.mtbName.TabIndex = 5;
            this.mtbName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbName.UseSelectable = true;
            this.mtbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbTreyler
            // 
            // 
            // 
            // 
            this.mtbTreyler.CustomButton.Image = null;
            this.mtbTreyler.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.mtbTreyler.CustomButton.Name = "";
            this.mtbTreyler.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbTreyler.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbTreyler.CustomButton.TabIndex = 1;
            this.mtbTreyler.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbTreyler.CustomButton.UseSelectable = true;
            this.mtbTreyler.CustomButton.Visible = false;
            this.mtbTreyler.Lines = new string[0];
            this.mtbTreyler.Location = new System.Drawing.Point(141, 198);
            this.mtbTreyler.MaxLength = 32767;
            this.mtbTreyler.Name = "mtbTreyler";
            this.mtbTreyler.PasswordChar = '\0';
            this.mtbTreyler.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbTreyler.SelectedText = "";
            this.mtbTreyler.SelectionLength = 0;
            this.mtbTreyler.SelectionStart = 0;
            this.mtbTreyler.ShortcutsEnabled = true;
            this.mtbTreyler.Size = new System.Drawing.Size(222, 23);
            this.mtbTreyler.TabIndex = 5;
            this.mtbTreyler.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbTreyler.UseSelectable = true;
            this.mtbTreyler.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbTreyler.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbImage
            // 
            // 
            // 
            // 
            this.mtbImage.CustomButton.Image = null;
            this.mtbImage.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.mtbImage.CustomButton.Name = "";
            this.mtbImage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbImage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbImage.CustomButton.TabIndex = 1;
            this.mtbImage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbImage.CustomButton.UseSelectable = true;
            this.mtbImage.CustomButton.Visible = false;
            this.mtbImage.Lines = new string[0];
            this.mtbImage.Location = new System.Drawing.Point(141, 169);
            this.mtbImage.MaxLength = 32767;
            this.mtbImage.Name = "mtbImage";
            this.mtbImage.PasswordChar = '\0';
            this.mtbImage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbImage.SelectedText = "";
            this.mtbImage.SelectionLength = 0;
            this.mtbImage.SelectionStart = 0;
            this.mtbImage.ShortcutsEnabled = true;
            this.mtbImage.Size = new System.Drawing.Size(222, 23);
            this.mtbImage.TabIndex = 5;
            this.mtbImage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbImage.UseSelectable = true;
            this.mtbImage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbImage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(369, 18);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Описание";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(141, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Категория";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(141, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Название";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(17, 260);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(118, 23);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "Отменить";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(543, 260);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(118, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Сохранить";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(17, 198);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(118, 23);
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "Выбрать трейлер";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(17, 169);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Выбрать обложку";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(17, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mtbYear
            // 
            // 
            // 
            // 
            this.mtbYear.CustomButton.Image = null;
            this.mtbYear.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.mtbYear.CustomButton.Name = "";
            this.mtbYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbYear.CustomButton.TabIndex = 1;
            this.mtbYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbYear.CustomButton.UseSelectable = true;
            this.mtbYear.CustomButton.Visible = false;
            this.mtbYear.Lines = new string[0];
            this.mtbYear.Location = new System.Drawing.Point(177, 140);
            this.mtbYear.MaxLength = 32767;
            this.mtbYear.Name = "mtbYear";
            this.mtbYear.PasswordChar = '\0';
            this.mtbYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbYear.SelectedText = "";
            this.mtbYear.SelectionLength = 0;
            this.mtbYear.SelectionStart = 0;
            this.mtbYear.ShortcutsEnabled = true;
            this.mtbYear.Size = new System.Drawing.Size(112, 23);
            this.mtbYear.TabIndex = 5;
            this.mtbYear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbYear.UseSelectable = true;
            this.mtbYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(141, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(30, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Год";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AddNewFilmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "AddNewFilmControl";
            this.Size = new System.Drawing.Size(690, 300);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox mtbDescryption;
        private MetroFramework.Controls.MetroTextBox mtbName;
        private MetroFramework.Controls.MetroTextBox mtbTreyler;
        private MetroFramework.Controls.MetroTextBox mtbImage;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox mtbYear;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
