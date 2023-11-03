using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalAssignment;

namespace FinalAssignmentC_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Operations.DefaultDatas();
            AppointmentManager.OnBooking += AppointmentManager.BookingHandler; 
            Operations.MainMenu();
        }
    }
}