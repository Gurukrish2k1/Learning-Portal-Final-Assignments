using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public enum Department { Depts, Diabetology,Nephrology, Cardiology, Neonatology, Anaesthesiology}
namespace FinalAssignmentC_
{
    /// <summary>
    /// Doctor class holds the necessary properties to hold the doctor details
    /// </summary> 
    public class Doctor
    {
        /// <summary>
        /// Constructor of the doctor class
        /// </summary>
        /// <param name="doctorID"></param>
        /// <param name="name"></param>
        /// <param name="department"></param> 
        public Doctor(int doctorID, string name, Department department)
        {
            Department = department;
            Name = name;
            DoctorID = doctorID;
        }
        /// <summary>
        /// This property holds the doctor ID
        /// </summary>
        public int DoctorID { get; set; }
        /// <summary>
        /// This property holds the doctor name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// This property holds the doctor specialization
        /// </summary>
        public Department Department { get; set; }
    }
}