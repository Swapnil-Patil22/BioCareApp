using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioCare.Model
{
  public  class ReminderController
    {
        private static ReminderController instance = null;
        private static readonly object padlock = new object();

        public List<ReminderModel> Reminders { get; set; }

        private ReminderController()
        {

        }

        public List<ReminderModel> GetRemindersData()
        {
            List<ReminderModel> Reminders = new List<ReminderModel>
            {
                new ReminderModel(1,  "Sang", "1234567890", "BN R0001", "09/20/2017", "10.AM","Title","Description of Reminder"),
                new ReminderModel(1,  "Akil", "1234567890","BN R0002", "09/20/2017", "11.AM","Title","Description of Reminder"),
                 new ReminderModel(1,  "John","1234567890", "BN R0003", "09/20/2017", "10.AM","Title","Description of Reminder"),
                new ReminderModel(1,  "Peter","1234567890", "BN R0004", "09/20/2017", "11.AM","Title","Description of Reminder"),
                new ReminderModel(1,  "Name 5","1234567890", "BN R0005", "09/20/2017", "10.AM","Title","Description of Reminder"),
                new ReminderModel(1,  "Name 6","1234567890", "BN R0006", "09/20/2017", "11.AM","Title","Description of Reminder"),
                 new ReminderModel(1,  "Name 7","1234567890", "BN R0007", "09/20/2017", "10.AM","Title","Description of Reminder"),
                new ReminderModel(1,  "Name 8","1234567890", "BN R0008", "09/20/2017", "11.AM","Title","Description of Reminder"),
                 new ReminderModel(1,  "Name 9","1234567890", "BN R0009", "09/20/2017", "10.AM","Title","Description of Reminder"),
                new ReminderModel(1,  "Name 10", "1234567890","BN R0010", "09/20/2017", "11.AM","Title","Description of Reminder"),
                 new ReminderModel(1,  "Name 11","1234567890", "BN R0011", "09/20/2017", "10.AM","Title","Description of Reminder"),
                new ReminderModel(1,  "Name 12", "1234567890","BN R0012", "09/20/2017", "11.AM","Title","Description of Reminder"),

            };
            return Reminders;
        }

        public static ReminderController InstanceCreation()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new ReminderController();
                }
                return instance;
            }
        }
    }
}
