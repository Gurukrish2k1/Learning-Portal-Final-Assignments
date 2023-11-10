using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignmentC_
{
    /// <summary>
    /// Appointment manager class holds the necessary methods to book appointments and  properties required
    /// </summary> 
    public class AppointmentManager
    {
        // delegate
        public delegate void BookingEventHandler(object sender, EventArgs eargs);
        // event
        public static event BookingEventHandler OnBooking;

        public static Patient Currentpatient;
        public static Doctor CurrentDoctor;

        protected static List<Doctor> doctorList = new List<Doctor>();
        protected static List<Patient> patientList = new List<Patient>();
        protected static List<Appointment> appointmentList = new List<Appointment>();


        protected static void BookAppointment()
        {
            System.Console.WriteLine("Departments:");
            System.Console.WriteLine("1." + Department.Diabetology);
            System.Console.WriteLine("2." + Department.Nephrology);
            System.Console.WriteLine("3." + Department.Cardiology);
            System.Console.WriteLine("4." + Department.Neonatology);
            System.Console.WriteLine("5." + Department.Anaesthesiology);
            System.Console.WriteLine();
            System.Console.WriteLine("Choose the number of the corresponding department to book a slot");
            bool temp = int.TryParse(Console.ReadLine(), out int option);
            while (!temp || option <= 0 || option > 5)
            {
                System.Console.WriteLine("Invalid option. Enter again");
                System.Console.WriteLine("1." + Department.Diabetology);
                System.Console.WriteLine("2." + Department.Nephrology);
                System.Console.WriteLine("3." + Department.Cardiology);
                System.Console.WriteLine("4." + Department.Neonatology);
                System.Console.WriteLine("5." + Department.Anaesthesiology);
                System.Console.WriteLine();
                System.Console.WriteLine("Choose the number of the corresponding department to book a slot");
                temp = int.TryParse(Console.ReadLine(), out option);
            }

            Department dept = (Department)option;
            System.Console.WriteLine("Enter the problem which you need to diagnose");
            string problem = Console.ReadLine();

            DateOnly today = DateOnly.Parse(DateTime.Now.ToString("MM-dd-yyyy"));
            foreach (Doctor doctors in doctorList)
            {
                if (dept == doctors.Department)
                {
                    int count = 0;
                    foreach (Appointment app in appointmentList)
                    {
                        if (doctors.DoctorID == app.DoctorID && today == app.Date)
                        {
                            count++;
                        }
                    }
                    if (count < 2)
                    {
                        CurrentDoctor = doctors;
                        System.Console.WriteLine($"Appointment is confirmed for the date – {today}. To book press “Y”, to cancel press “N");
                        string choice = Console.ReadLine().ToUpper();
                        while (choice != "N" && choice != "Y")
                        {
                            System.Console.WriteLine("Invalid option. Enter again");
                            System.Console.WriteLine($"Appointment is confirmed for the date – {today}. To book press “Y”, to cancel press “N");
                            choice = Console.ReadLine().ToUpper();
                        }
                        if (choice == "Y")
                        {
                            Appointment newPatient = new(Currentpatient.PatientID, doctors.DoctorID, today, problem);
                            appointmentList.Add(newPatient);
                            OnBooking?.Invoke(null, EventArgs.Empty);
                            System.Console.WriteLine();
                            System.Console.WriteLine("Your Appointment ID is : " + newPatient.AppointmentID);
                        }
                        else
                        {
                            System.Console.WriteLine("The booking is not done. Returning to Patient Menu");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("This doctor already has 2 appointments ");

                    }
                    break;
                }

            }
        }

        public static void BookingHandler(object sender, EventArgs eargs)
        {
            System.Console.WriteLine("Booking successful!!!");
        }
        protected static void ViewAppointments()
        {
            bool flag = false;
            System.Console.WriteLine();
            System.Console.WriteLine("Appointment Details:");
            foreach (Appointment details in appointmentList)
            {
                if (Currentpatient.PatientID == details.PatientID)
                {
                    flag = true;
                    System.Console.WriteLine($"AppointmentID - {details.AppointmentID.ToString().PadRight(19)}  \nPatientID - {details.PatientID.ToString().PadRight(15)}  \nPatient Name - {Currentpatient.Name.PadRight(17)}  \nGender - {Currentpatient.Gender.ToString().PadRight(21)}   \nDoctorID - {details.DoctorID.ToString().PadRight(19)}  \nDoctor Name - {CurrentDoctor.Name.PadRight(16)}  \nAppointment Date - {details.Date.ToString().PadRight(11)}  \nMedical Condition - {details.Problem.PadRight(10)}");
                }
            }
            if (!flag)
            {
                System.Console.WriteLine("You have not booked any appointment");
            }
            System.Console.WriteLine();
        }

        protected static void EditPatientProfile()
        {
            System.Console.WriteLine("Choose the number corresponding to the detail to edit \n1.Name \n2.Age \n3.Gender \n4.Password");
            bool temp = int.TryParse(Console.ReadLine(), out int option);
            while (!temp || option <= 0 || option > 4)
            {
                System.Console.WriteLine("Invalid option. Enter again");
                System.Console.WriteLine("Choose the number corresponding to the detail to edit \n1.Name \n2.Age \n3.Gender \n4.Password");
                temp = int.TryParse(Console.ReadLine(), out option);
            }
            switch (option)
            {
                case 1:
                    {
                        System.Console.WriteLine("Enter the new name");
                        string name = Console.ReadLine();
                        Currentpatient.Name = name;
                        break;
                    }
                case 2:
                    {
                        System.Console.WriteLine("Enter the new age");
                        bool temp1 = int.TryParse(Console.ReadLine(), out int age);
                        while (!temp || age <= 0)
                        {
                            System.Console.WriteLine("Invalid option. Enter again");
                            System.Console.WriteLine("Enter the new age");
                            temp1 = int.TryParse(Console.ReadLine(), out age);
                        }
                        Currentpatient.Age = age;
                        break;
                    }
                case 3:
                    {
                        System.Console.WriteLine("Enter the new Gender. 0.Male  1.Female");
                        Gender gender = Enum.Parse<Gender>(Console.ReadLine());
                        Currentpatient.Gender = gender;
                        break;
                    }
                case 4:
                    {
                        System.Console.WriteLine("Enter the new Password");
                        string password = Console.ReadLine();
                        Currentpatient.Password = password;
                        break;
                    }

            }
        }
    }
}