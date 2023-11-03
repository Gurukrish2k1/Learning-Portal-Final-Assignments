using System;
using FinalAssignmentC_;
namespace FinalAssignment;
class Operations : AppointmentManager
{

    public static void DefaultDatas()
    {
        // Doctor details
        doctorList.Add(new Doctor(1, "Nancy", Department.Anaesthesiology));
        doctorList.Add(new Doctor(2, "Andrew", Department.Cardiology));
        doctorList.Add(new Doctor(3, "Janet", Department.Diabetology));
        doctorList.Add(new Doctor(4, "Margaret", Department.Neonatology));
        doctorList.Add(new Doctor(5, "Steven", Department.Nephrology));


        // Patient Details
        patientList.Add(new Patient("welcome", "Robert", 40, Gender.Male));
        patientList.Add(new Patient("welcome", "Laura", 36, Gender.Female));
        patientList.Add(new Patient("welcome", "Anne", 42, Gender.Female));

        // Appointment Details
        appointmentList.Add(new Appointment(1, 2, DateOnly.Parse("2012,8,3"), "Heart problem"));
        appointmentList.Add(new Appointment(1, 5, DateOnly.Parse("2012,8,3"), "Spinal cord injury"));
        appointmentList.Add(new Appointment(2, 2, DateOnly.Parse("2012,8,3"), "Heart attack"));
    }

    // Method to display main menu
    public static void MainMenu()
    {
        System.Console.WriteLine("Welcome to the Hospital");
        bool flag = true;
        do
        {
            System.Console.WriteLine("Choose from the option number to register or Login\n1.Login \n2.Registration \n3.Exit");
            bool temp = int.TryParse(Console.ReadLine(), out int option);
            while (!temp || option <= 0 || option > 3)
            {
                System.Console.WriteLine("Invalid Option. Enter agian");
                System.Console.WriteLine("Choose from the option number to register or Login\n1.Login \n2.Registration\n3.Exit");
                temp = int.TryParse(Console.ReadLine(), out option);
            }

            switch (option)
            {
                case 1:
                    {
                        Login();
                        break;
                    }

                case 2:
                    {
                        Registration();
                        break;
                    }

                case 3:
                    {
                        flag = false;
                        break;
                    }
            }
        } while (flag);
        System.Console.WriteLine("Thank you for visiting come again!!!");
    }

    // Method for registration
    static void Registration()
    {
        System.Console.WriteLine("Enter the user name");
        string name = Console.ReadLine();

        System.Console.WriteLine("Enter the age");
        bool temp = int.TryParse(Console.ReadLine(), out int age);
        while (!temp || age <= 0)
        {
            System.Console.WriteLine("invalid age. Enter again");
            System.Console.WriteLine("Enter the age");
            temp = int.TryParse(Console.ReadLine(), out age);
        }

        System.Console.WriteLine("Enter your password");
        string password = Console.ReadLine();

        System.Console.WriteLine("Enter your gender");
        bool temp1 = Enum.TryParse<Gender>(Console.ReadLine(), out Gender gender);
        while (!temp1 || gender != (Gender)1 && gender!= (Gender)0)
        {
            System.Console.WriteLine("Invalid input. Enter again");
            System.Console.WriteLine("Enter your gender");
            temp1 = Enum.TryParse<Gender>(Console.ReadLine(), out gender);
        }
        Patient patient = new(password, name, age, gender);
        patientList.Add(patient);

        System.Console.WriteLine("Successfully Registered. Your PatientID is : " + patient.PatientID);
    }

    //Method to login
    static void Login()
    {
        System.Console.WriteLine("Enter the username");
        string userName = Console.ReadLine().ToLower();

        System.Console.WriteLine("Enter the password");
        string password = Console.ReadLine();

        bool flag = false;
        foreach (Patient patients in patientList)
        {
            if (patients.Name.ToLower() == userName && password == patients.Password)
            {
                flag = true;
                Currentpatient = patients;
                System.Console.WriteLine("Successfully Logged in!!!!");
                break;
            }
        }
        if (flag)
        {
            SubMenu();
        }
        else
        {
            System.Console.WriteLine("Invalid Passsword or username. Please try again or register your profile if not registered.");
        }
    }

    //Method to show submenu
    static void SubMenu()
    {
        bool flag = true;
        do
        {
            System.Console.WriteLine("Choose the action to perform. \n1.Book Appointment \n2.View Appointment Details \n3.Edit my profile \n4.Exit");
            bool temp = int.TryParse(Console.ReadLine(), out int option);
            while (!temp || option <= 0 || option > 4)
            {
                System.Console.WriteLine("Invalid option. Eneter again!!");
                System.Console.WriteLine("Choose the action to perform. \n1.Book Appointment \n2.View Appointment Details \n3.Edit my profile");
                temp = int.TryParse(Console.ReadLine(), out option);
            }

            switch (option)
            {
                case 1:
                    {
                        AppointmentManager.BookAppointment();
                        break;
                    }
                case 2:
                    {
                        AppointmentManager.ViewAppointments();
                        break;
                    }
                case 3:
                    {
                        AppointmentManager.EditPatientProfile();
                        break;
                    }
                case 4:
                    {
                        flag = false;
                        break;
                    }
            }
        } while (flag);
    }
}