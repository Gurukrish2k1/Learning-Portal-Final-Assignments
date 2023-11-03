using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignmentC_
{
    public class Appointment
    {
        private static int s_appointmentID = 0;
        /// <summary>
        /// This property holds the Appointment ID
        /// </summary>
        public int AppointmentID { get; }
        /// <summary>
        /// This property holds the Patient ID
        /// </summary>
        public int PatientID { get; set; }
        /// <summary>
        /// This property holds the doctor ID
        /// </summary>
        public int DoctorID { get; set; }
        /// <summary>
        /// This property holds the Appointment date
        /// </summary>
        public DateOnly Date { get; set; }
        /// <summary>
        /// This property holds the Problem to be diagnosed
        /// </summary>
        public string Problem { get; set; }

        /// <summary>
        /// Constructor that holds the necessary details of the class
        /// </summary>
        /// <param name="patientID"></param>
        /// <param name="doctorID"></param>
        /// <param name="date"></param>
        /// <param name="problem"></param>
        public Appointment(int patientID, int doctorID,DateOnly date, string problem)
        {
            AppointmentID = ++s_appointmentID;
            PatientID = patientID;
            DoctorID = doctorID;
            Date = date;
            Problem = problem;

        }
    }

}