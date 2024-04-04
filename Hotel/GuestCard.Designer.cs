namespace Hotel
{
    partial class GuestCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestCard));
            this.NameLbl = new System.Windows.Forms.Label();
            this.BirthLbl = new System.Windows.Forms.Label();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DaysLbl = new System.Windows.Forms.Label();
            this.AnimalsCheckBox = new System.Windows.Forms.CheckBox();
            this.GuestCardLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.Location = new System.Drawing.Point(47, 109);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(290, 45);
            this.NameLbl.TabIndex = 22;
            this.NameLbl.Text = "ФИО";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BirthLbl
            // 
            this.BirthLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BirthLbl.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthLbl.Location = new System.Drawing.Point(47, 183);
            this.BirthLbl.Name = "BirthLbl";
            this.BirthLbl.Size = new System.Drawing.Size(285, 38);
            this.BirthLbl.TabIndex = 23;
            this.BirthLbl.Text = "Дата рождения";
            this.BirthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(44, 262);
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(119, 22);
            this.NumericUpDown.TabIndex = 24;
            // 
            // DaysLbl
            // 
            this.DaysLbl.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysLbl.Location = new System.Drawing.Point(194, 255);
            this.DaysLbl.Name = "DaysLbl";
            this.DaysLbl.Size = new System.Drawing.Size(185, 33);
            this.DaysLbl.TabIndex = 25;
            this.DaysLbl.Text = "Количество дней";
            this.DaysLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnimalsCheckBox
            // 
            this.AnimalsCheckBox.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnimalsCheckBox.Location = new System.Drawing.Point(44, 316);
            this.AnimalsCheckBox.Name = "AnimalsCheckBox";
            this.AnimalsCheckBox.Size = new System.Drawing.Size(295, 45);
            this.AnimalsCheckBox.TabIndex = 26;
            this.AnimalsCheckBox.Text = "Путешествую с животными";
            this.AnimalsCheckBox.UseVisualStyleBackColor = true;
            // 
            // GuestCardLbl
            // 
            this.GuestCardLbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GuestCardLbl.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestCardLbl.Location = new System.Drawing.Point(47, 25);
            this.GuestCardLbl.Name = "GuestCardLbl";
            this.GuestCardLbl.Size = new System.Drawing.Size(290, 53);
            this.GuestCardLbl.TabIndex = 27;
            this.GuestCardLbl.Text = "Карточка гостя";
            this.GuestCardLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuestCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(391, 399);
            this.Controls.Add(this.GuestCardLbl);
            this.Controls.Add(this.AnimalsCheckBox);
            this.Controls.Add(this.DaysLbl);
            this.Controls.Add(this.NumericUpDown);
            this.Controls.Add(this.BirthLbl);
            this.Controls.Add(this.NameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestCard";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label BirthLbl;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.Label DaysLbl;
        private System.Windows.Forms.CheckBox AnimalsCheckBox;
        private System.Windows.Forms.Label GuestCardLbl;
    }
}