using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioCare.Model
{
    public class BookingModel
    {
        public int Id { get; set; }
        public string BookingNo { get; set; }
        public string AppointmentDateTime { get; set; }
        public string ActualStart { get; set; }
        public string ActualEnd { get; set; }
        public string Duration { get; set; }
        public string TypeOfService { get; set; }
        public string Location { get; set; }
        public string CustomerName { get; set; }
        public string MobileNo { get; set; }
        public string Status { get; set; }
        public string VehicleNo { get; set; }
        public string ListOfEquipment { get; set; }
        public string TeamName { get; set; }
        public string TeamLeader { get; set; }
        public string Workers { get; set; }
        public string Remarks { get; set; }

        public BookingModel(int id, string bookingNo, string appointmentDateTime, string actualStart, string actualEnd, string duration, string typeOfService,
            string location, string customerName, string mobileNo, string status, string vehicleNo, string listOfEquipment, string teamName, string teamLeader,
            string workers, string remarks)
        {
            Id = id;
            BookingNo = bookingNo;
            AppointmentDateTime = appointmentDateTime;
            ActualStart = actualStart;
            ActualEnd = actualEnd;
            Duration = duration;
            TypeOfService = typeOfService;
            Location = location;
            CustomerName = customerName;
            MobileNo = mobileNo;
            Status = status;
            VehicleNo = vehicleNo;
            ListOfEquipment = listOfEquipment;
            TeamName = teamName;
            TeamLeader = teamLeader;
            Workers = workers;
            Remarks = remarks;
        }

    }
}
