using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hotel
{
    public partial class MainForm : Form
    {
        private Guest selectedGuest = null;
        public MainForm()
        {
            InitializeComponent();

            DateTimeLbl.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(Timer_Tick);

            this.SearchTextBox.AutoSize = false;
            this.SearchTextBox.Size = new Size(this.SearchTextBox.Size.Width, 38);

            ForDataGW();
            SelectedGuest();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTimeLbl.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"); 
        }


        private void ForDataGW()
        { 
            List<Guest> guests = Guest.Guests;
            string search = SearchTextBox.Text.ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                guests = guests.Where(g => g.Number.ToString() == search || $"{g.Surname} {g.Name} {g.Patronymic}".ToLower().Contains(search)).ToList();
            }
            MainDataGridView.DataSource = guests;
            MainDataGridView.Columns[0].Visible = false;
            MainDataGridView.Columns[1].HeaderText = "Номер";
            MainDataGridView.Columns[2].HeaderText = "Имя";
            MainDataGridView.Columns[3].HeaderText = "Фамилия";
            MainDataGridView.Columns[4].HeaderText = "Отчество";
            MainDataGridView.Columns[5].HeaderText = "Статус";
            MainDataGridView.Columns[6].HeaderText = "День рождения";
            MainDataGridView.Columns[7].Visible = false;
            MainDataGridView.Columns[8].HeaderText = "Дата заезда";
            MainDataGridView.Columns[9].HeaderText = "Кол-во дней";
            MainDataGridView.Columns[10].Visible = false;
            MainDataGridView.Columns[11].Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"../../Guests.xml");
            MainDataGridView.DataSource = ds.Tables[0];
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ForDataGW();
        }

        private void GuestCardBtn_Click(object sender, EventArgs e)
        {
            GuestCard guestCard = new GuestCard();
            guestCard.Show();
        }

        private void SelectedGuest()
        {
            if (selectedGuest != null)
            {
                NumberLbl.Text = $"Номер № {selectedGuest.Number}";
                NameLbl.Text = $"{selectedGuest.Surname} {selectedGuest.Name} {selectedGuest.Patronymic}";
                ComeLbl.Text = selectedGuest.ArrivalDate.ToString("dd.MM.yyyy");
                LeaveLbl.Text = selectedGuest.ArrivalDate.AddDays(selectedGuest.Days).ToString("dd.MM.yyyy");
            }
        }
    }
}
