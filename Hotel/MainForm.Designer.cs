namespace Hotel
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TopSplitter = new System.Windows.Forms.Splitter();
            this.LeftSplitter = new System.Windows.Forms.Splitter();
            this.RightSplitter = new System.Windows.Forms.Splitter();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.DateTimeLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.GuestsLbl = new System.Windows.Forms.Label();
            this.NumberLbl = new System.Windows.Forms.Label();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.NewRadBtn = new System.Windows.Forms.RadioButton();
            this.BookedRadBtn = new System.Windows.Forms.RadioButton();
            this.EndRadBtn = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimePicBox = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.GuestPicBox = new System.Windows.Forms.PictureBox();
            this.StatusCardLbl = new System.Windows.Forms.Label();
            this.StatusCmbBox = new System.Windows.Forms.ComboBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.ComeLbl = new System.Windows.Forms.Label();
            this.LeaveLbl = new System.Windows.Forms.Label();
            this.GuestCardBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(181, 0);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(675, 30);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // TopSplitter
            // 
            this.TopSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopSplitter.Location = new System.Drawing.Point(0, 0);
            this.TopSplitter.Name = "TopSplitter";
            this.TopSplitter.Size = new System.Drawing.Size(920, 51);
            this.TopSplitter.TabIndex = 3;
            this.TopSplitter.TabStop = false;
            // 
            // LeftSplitter
            // 
            this.LeftSplitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftSplitter.Location = new System.Drawing.Point(0, 51);
            this.LeftSplitter.Name = "LeftSplitter";
            this.LeftSplitter.Size = new System.Drawing.Size(181, 521);
            this.LeftSplitter.TabIndex = 4;
            this.LeftSplitter.TabStop = false;
            // 
            // RightSplitter
            // 
            this.RightSplitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightSplitter.Location = new System.Drawing.Point(601, 51);
            this.RightSplitter.Name = "RightSplitter";
            this.RightSplitter.Size = new System.Drawing.Size(319, 521);
            this.RightSplitter.TabIndex = 5;
            this.RightSplitter.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // DateTimeLbl
            // 
            this.DateTimeLbl.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimeLbl.Location = new System.Drawing.Point(1, 3);
            this.DateTimeLbl.Name = "DateTimeLbl";
            this.DateTimeLbl.Size = new System.Drawing.Size(130, 45);
            this.DateTimeLbl.TabIndex = 6;
            this.DateTimeLbl.Text = "Дата и время";
            this.DateTimeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StatusLbl
            // 
            this.StatusLbl.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLbl.Location = new System.Drawing.Point(12, 64);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(149, 33);
            this.StatusLbl.TabIndex = 7;
            this.StatusLbl.Text = "Статус";
            this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuestsLbl
            // 
            this.GuestsLbl.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestsLbl.Location = new System.Drawing.Point(187, 64);
            this.GuestsLbl.Name = "GuestsLbl";
            this.GuestsLbl.Size = new System.Drawing.Size(186, 33);
            this.GuestsLbl.TabIndex = 8;
            this.GuestsLbl.Text = "Список гостей";
            this.GuestsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberLbl
            // 
            this.NumberLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberLbl.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLbl.Location = new System.Drawing.Point(613, 64);
            this.NumberLbl.Name = "NumberLbl";
            this.NumberLbl.Size = new System.Drawing.Size(110, 33);
            this.NumberLbl.TabIndex = 9;
            this.NumberLbl.Text = "Номер №";
            this.NumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainDataGridView.Location = new System.Drawing.Point(181, 100);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.RowHeadersWidth = 51;
            this.MainDataGridView.RowTemplate.Height = 24;
            this.MainDataGridView.Size = new System.Drawing.Size(420, 472);
            this.MainDataGridView.TabIndex = 10;
            // 
            // NewRadBtn
            // 
            this.NewRadBtn.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewRadBtn.Location = new System.Drawing.Point(5, 152);
            this.NewRadBtn.Name = "NewRadBtn";
            this.NewRadBtn.Size = new System.Drawing.Size(166, 46);
            this.NewRadBtn.TabIndex = 12;
            this.NewRadBtn.TabStop = true;
            this.NewRadBtn.Text = "Свободные";
            this.NewRadBtn.UseVisualStyleBackColor = true;
            // 
            // BookedRadBtn
            // 
            this.BookedRadBtn.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookedRadBtn.Location = new System.Drawing.Point(5, 204);
            this.BookedRadBtn.Name = "BookedRadBtn";
            this.BookedRadBtn.Size = new System.Drawing.Size(166, 46);
            this.BookedRadBtn.TabIndex = 13;
            this.BookedRadBtn.TabStop = true;
            this.BookedRadBtn.Text = "Заняты";
            this.BookedRadBtn.UseVisualStyleBackColor = true;
            // 
            // EndRadBtn
            // 
            this.EndRadBtn.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndRadBtn.Location = new System.Drawing.Point(5, 256);
            this.EndRadBtn.Name = "EndRadBtn";
            this.EndRadBtn.Size = new System.Drawing.Size(166, 49);
            this.EndRadBtn.TabIndex = 14;
            this.EndRadBtn.TabStop = true;
            this.EndRadBtn.Text = "Выписываются";
            this.EndRadBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Hotel.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(862, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // TimePicBox
            // 
            this.TimePicBox.Image = global::Hotel.Properties.Resources.pngwing_com;
            this.TimePicBox.Location = new System.Drawing.Point(128, 1);
            this.TimePicBox.Name = "TimePicBox";
            this.TimePicBox.Size = new System.Drawing.Size(47, 44);
            this.TimePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TimePicBox.TabIndex = 15;
            this.TimePicBox.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(5, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(166, 46);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Зарезервировано";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // GuestPicBox
            // 
            this.GuestPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GuestPicBox.Location = new System.Drawing.Point(688, 112);
            this.GuestPicBox.Name = "GuestPicBox";
            this.GuestPicBox.Size = new System.Drawing.Size(159, 138);
            this.GuestPicBox.TabIndex = 18;
            this.GuestPicBox.TabStop = false;
            // 
            // StatusCardLbl
            // 
            this.StatusCardLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusCardLbl.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusCardLbl.Location = new System.Drawing.Point(607, 255);
            this.StatusCardLbl.Name = "StatusCardLbl";
            this.StatusCardLbl.Size = new System.Drawing.Size(111, 33);
            this.StatusCardLbl.TabIndex = 19;
            this.StatusCardLbl.Text = "Статус";
            this.StatusCardLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusCmbBox
            // 
            this.StatusCmbBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusCmbBox.FormattingEnabled = true;
            this.StatusCmbBox.Location = new System.Drawing.Point(730, 264);
            this.StatusCmbBox.Name = "StatusCmbBox";
            this.StatusCmbBox.Size = new System.Drawing.Size(178, 24);
            this.StatusCmbBox.TabIndex = 20;
            // 
            // NameLbl
            // 
            this.NameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.Location = new System.Drawing.Point(618, 293);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(290, 45);
            this.NameLbl.TabIndex = 21;
            this.NameLbl.Text = "ФИО";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComeLbl
            // 
            this.ComeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComeLbl.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComeLbl.Location = new System.Drawing.Point(623, 361);
            this.ComeLbl.Name = "ComeLbl";
            this.ComeLbl.Size = new System.Drawing.Size(285, 38);
            this.ComeLbl.TabIndex = 22;
            this.ComeLbl.Text = "Дата заезда";
            this.ComeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LeaveLbl
            // 
            this.LeaveLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaveLbl.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeaveLbl.Location = new System.Drawing.Point(623, 418);
            this.LeaveLbl.Name = "LeaveLbl";
            this.LeaveLbl.Size = new System.Drawing.Size(285, 38);
            this.LeaveLbl.TabIndex = 23;
            this.LeaveLbl.Text = "Дата выезда";
            this.LeaveLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GuestCardBtn
            // 
            this.GuestCardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GuestCardBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GuestCardBtn.FlatAppearance.BorderSize = 4;
            this.GuestCardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuestCardBtn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestCardBtn.Location = new System.Drawing.Point(655, 522);
            this.GuestCardBtn.Name = "GuestCardBtn";
            this.GuestCardBtn.Size = new System.Drawing.Size(214, 38);
            this.GuestCardBtn.TabIndex = 24;
            this.GuestCardBtn.Text = "Просмотр карточки";
            this.GuestCardBtn.UseVisualStyleBackColor = true;
            this.GuestCardBtn.Click += new System.EventHandler(this.GuestCardBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 572);
            this.Controls.Add(this.GuestCardBtn);
            this.Controls.Add(this.LeaveLbl);
            this.Controls.Add(this.ComeLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.StatusCmbBox);
            this.Controls.Add(this.StatusCardLbl);
            this.Controls.Add(this.GuestPicBox);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TimePicBox);
            this.Controls.Add(this.EndRadBtn);
            this.Controls.Add(this.BookedRadBtn);
            this.Controls.Add(this.NewRadBtn);
            this.Controls.Add(this.MainDataGridView);
            this.Controls.Add(this.NumberLbl);
            this.Controls.Add(this.GuestsLbl);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.DateTimeLbl);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.RightSplitter);
            this.Controls.Add(this.LeftSplitter);
            this.Controls.Add(this.TopSplitter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Splitter TopSplitter;
        private System.Windows.Forms.Splitter LeftSplitter;
        private System.Windows.Forms.Splitter RightSplitter;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label DateTimeLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label GuestsLbl;
        private System.Windows.Forms.Label NumberLbl;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.RadioButton NewRadBtn;
        private System.Windows.Forms.RadioButton BookedRadBtn;
        private System.Windows.Forms.RadioButton EndRadBtn;
        private System.Windows.Forms.PictureBox TimePicBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox GuestPicBox;
        private System.Windows.Forms.Label StatusCardLbl;
        private System.Windows.Forms.ComboBox StatusCmbBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label ComeLbl;
        private System.Windows.Forms.Label LeaveLbl;
        private System.Windows.Forms.Button GuestCardBtn;
    }
}

