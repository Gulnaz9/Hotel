using System;
using System.Collections.Generic;

namespace Hotel
{
    public class Guest
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Status { get; set; }
        public DateTime Birthday { get; set; }
        public string Pay { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int Days { get; set; }
        public string PhotoPath { get; set; }
        public bool WithAnimal { get; set; }

        public static List<Guest> Guests { get; set; } = new List<Guest>();
        public Guest() { }

        public Guest( int id, int number, string surname, string name, string patronymic, string status, DateTime birthday, string pay, DateTime arrivalDate, int days, string photoPath, bool withAnimal)
        {
            Id = id;
            Number = number;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Status = status;
            Birthday = birthday;
            Pay = pay;
            ArrivalDate = arrivalDate;
            Days = days;
            PhotoPath = photoPath;
            WithAnimal = withAnimal;
        }
        /// <summary>
        /// м-д, который должен связывать класс гостя со значениями файла (почему то не работает)
        /// </summary>
        /*public void Read()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Guests.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Guest>));
            using (FileStream stream = File.Open(path, FileMode.Open))
            {
                Guests = (List<Guest>))serializer.Deserialize(stream);
            }
        }*/
    }
}
