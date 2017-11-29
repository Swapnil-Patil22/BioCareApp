using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioCare.Model
{
  public class ReminderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string BookingNo { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ReminderModel(int id, string name, string number, string bookingNo, string date,
              string time, string title, string description)
        {
            Id = id;
            Name = name;
            Number = number;
            BookingNo = bookingNo;
            Date = date;
            Time = time;
            Title = title;
            Description = description;
        }
    }
}
