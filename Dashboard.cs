using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicaa

{ 
    public class Dashboard
    {

        public List<Patient> PatientsList;


        public Dashboard(List<Patient> patients_list)
        {
            this.PatientsList = patients_list;

        }


    }

