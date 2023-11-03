using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public enum Gender { Male, Female }
namespace FinalAssignmentC_
{
    /// <summary>
    /// This class holds the necessary details required for the Patient
    /// </summary>
    public class Patient
    {
        private static int s_patientID = 0;
        /// <summary>
        /// This property holds the Patient's name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// This property holds the Patient's age
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// This property holds the Patient's gender
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// This property holds the Patient's password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// This property holds the Patient's ID
        /// </summary>
        public int PatientID { get;}

        public Patient(string password, string name, int age, Gender gender)
        {
            PatientID = ++s_patientID;
            Name = name;
            Age = age;
            Password = password;
            Gender = gender;

        }

    }
}