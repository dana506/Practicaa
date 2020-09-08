using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicaa
{
    //handle dob exception, make sure dob is of DateTime type
    class InvalidDateOfBirthExeption : Exception
    {
        public DateTime DateOfBirth { get; set; }

        public InvalidDateOfBirthExeption(DateTime dob)
        {
            DateOfBirth = dob;
        }
    }

    public class Patient
    {
        #region Properties

        public string PatientLastName { get; set; }
        public string PatientFirstName { get; set; }
        public DateTime PatientDateOfBirth { get; set; }
        #endregion

        //function checks if the date introduced is not later than today's date
        public DateTime dob
        {
            get { return PatientDateOfBirth; }
            set
            {
                if (value > DateTime.Today.AddDays(-1))
                    throw new InvalidDateOfBirthExeption(value);

                PatientDateOfBirth = value;
            }
        }

        public List<Therapy> TherapiesList { get; set; }

        public Patient(string p_lastname, string p_firstname)
        {

            this.PatientLastName = p_lastname;
            this.PatientFirstName = p_firstname;
            this.PatientDateOfBirth = new DateTime();
            this.TherapiesList = null;
        }

        public Patient(string p_id, string p_lastname, string p_firstname, DateTime p_dob, List<Therapy> p_therapieslist)
        {

            this.PatientLastName = p_lastname;
            this.PatientFirstName = p_firstname;
            this.PatientDateOfBirth = p_dob;
            this.TherapiesList = p_therapieslist;
        }


    }
}

