using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioCare.Model
{
    public class Controller
    {
        private static Controller instance = null;
        private static readonly object padlock = new object();

        public List<BookingModel> Models { get; set; }
        private Controller()
        {
           
        }
        public List<BookingModel> GetBookingData()
        {
            List<BookingModel> Models = new List<BookingModel>
            {
                new BookingModel(1,  "BN001", "Sept 20th 2017","Test","Test","Test","Test","Test", "Testing 1", "SingaPore","NIL","Bus","Sample","Sample","Sample"
                ,"Sample","Sample"),
                new BookingModel(2,  "BN0002", "Sept 20th 2017","Test","Test","Test","Test","Test", "Testing 2", "SingaPore","NIL","Bus","Sample","Sample","Sample"
                ,"Sample","Sample"),
                new BookingModel(3,  "BN0003", "Sept 20th 2017","Test","Test","Test","Test","Test", "Testing 3", "SingaPore","NIL","Bus","Sample","Sample","Sample"
                ,"Sample","Sample"),
                new BookingModel(4,  "BN0004", "Sept 20th 2017","Test","Test","Test","Test","Test", "Testing 4","SingaPore","NIL","Bus","Sample","Sample","Sample"
                ,"Sample","Sample"),
                new BookingModel(1,  "BN0005", "Sept 20th 2017","Test","Test","Test","Test","Test","Testing 5", "SingaPore","NIL","Bus","Sample","Sample","Sample"
                ,"Sample","Sample"),
                new BookingModel(2, "BN0006", "Sept 20th 2017","Test","Test","Test","Test","Test", "Testing 6","SingaPore","NIL","Bus","Sample","Sample","Sample"
                ,"Sample","Sample"),
                new BookingModel(3,  "BN0007", "Sept 20th 2017","Test","Test","Test","Test","Test","Testing 7", "SingaPore","NIL","Bus","Sample","Sample","Sample"
                ,"Sample","Sample"),
                new BookingModel(4,  "BN0008", "Sept 20th 2017","Test","Test","Test","Test","Test", "Testing 8","SingaPore","NIL","Bus","Sample","Sample","Sample"
                ,"Sample","Sample")
            };
            return Models;
        }

        public static Controller InstanceCreation()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }
    }



}
