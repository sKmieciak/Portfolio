namespace AntheapRekrutacjaAPI
{
        public class Representative
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string nip { get; set; }
            public string companyName { get; set; }
        }

        public class Result
        {
            public Subject subject { get; set; }
            public string requestDateTime { get; set; }
            public string requestId { get; set; }
        }

        public class Root
        {
            public Result result { get; set; }
        }

        public class Subject
        {
            public List<object> authorizedClerks { get; set; }
            public string regon { get; set; }
            public string restorationDate { get; set; }
            public string workingAddress { get; set; }
            public bool hasVirtualAccounts { get; set; }
            public string statusVat { get; set; }
            public string krs { get; set; }
            public string restorationBasis { get; set; }
            public List<string> accountNumbers { get; set; }
            public string registrationDenialBasis { get; set; }
            public string nip { get; set; }
            public string removalDate { get; set; }
            public List<object> partners { get; set; }
            public string name { get; set; }
            public string registrationLegalDate { get; set; }
            public string removalBasis { get; set; }
            public string pesel { get; set; }
            public List<Representative> representatives { get; set; }
            public string residenceAddress { get; set; }
            public string registrationDenialDate { get; set; }
        }
 
}

