namespace SwiftClinicModels
{
    public class PopUp
    {
        public enum Gender
        {
            Male, Female, Others
        }
        public enum Marital
        {
            Single, Married, Divorce, Others
        }

        public enum PatientType
        {
            In_Patient, Out_Patient
        }

        public enum StockStatus
        {
            Add, Remove
        }
        public enum Qualifications
        {
            SSCE,
            NCE,
            OND,
            HND,
            Degree,
            Masters,
            Dr,
        }

        public enum PMode
        {
            Cash, Remita, Internet_Banking, POS
        }


        public enum SchemeName
        {
            NHIS
        }

        public enum Survival
        {
            Mother, Child, Both
        }

        public enum SurvivalRate
        {
            Before, During, After
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
        public enum ServiceType
        {
            School_Fee = 1, Accepatance_Fee, Supplementary_List_Payment, Hostel_Application_Fee, Acommodation_Payment_Fee, Faculty_Fee, Department_Fee
        }
        public enum RemitaPaymentType
        {
            MasterCard = 1, Visa, Verve, PocketMoni, POS, BANK_BRANCH, BANK_INTERNET, REMITA_PAY, RRRGEN
        }

    }

}


