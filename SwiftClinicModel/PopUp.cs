using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinghamWebApp.Models
{
    public class PopUp
    {
        public enum Gender
        {
            Male, Female
        }
        public enum Marital
        {
            Single, Married, Divorce, Others
        }

        public enum BloodGroup
        {
            A, AB, O, B
        }

        public enum Clinic
        {
            Eye, ENT, SOPD, MOPD, GIT, OPD, PHY, PAED
        }

        public enum AccountName
        {
            NHIS
        }

        public enum Role
        {
            Administrator, Doctor, Nurse, RecordPersonnel 
        }

        public enum Salutation
        {
            Dr, Nurse, Mr, Mrs, Miss, Engr, Pastor
        }

        public enum Religion
        {
            Christianity, Muslim, Traditional, Others
        }

        public enum Relationship
        {
            Father, Mother, Sister, Brother, Friend, Others
        }

        public enum State
        {
            Abia, Adamawa, AkwaIbom, Anambra, Bauchi, Bayelsa, Benue, Borno, CrossRiver, Delta, Ebonyi, Edo, Ekiti,
            Abuja, Gombe, Imo, Jigawa, Kaduna, Kano, Katsina, Kebbi, Kogi, Kwara, Lagos, Nasarawa, Niger, Ogun, Ondo, Osun,
            Oyo, Plateau, Rivers, Sokoto, Taraba, Yobe, Zamfara
        }

    }
	
}


