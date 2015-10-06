namespace aspCalcTax
{
    internal class Salary
    {
        public string ChurchMember { get; set; }
        public int BruttoSalary { get; set; }
        public int Tax { get; set; }
        public int NettoSalary { get; set; }
        public int Province { get; set; }
        private int ProvinceTax { get; set; }

        private double ChurchFee(string tProvince)
        {
            if (ChurchMember != "Yes")
            {
                return (0.0034);
            }

            switch (tProvince)
            {
                case "Motala":
                    return (0.0034 + 0.0116);
                case "Linköping":
                    return (0.0016 + 0.0121);
                case "Norrköping":
                    return (0.0025 + 0.0121);
            }
            return (0.0034);
        }

        public void Calculate()
        {
            string tempProvince = GetProvince();

            switch (tempProvince)
            {
                case "Motala":
                    //calc tax and net
                    Tax = (int) (BruttoSalary * (0.3190 + ChurchFee(tempProvince)));
                    NettoSalary = BruttoSalary - Tax;
                    break;
                case "Linköping":
                    Tax = (int) (BruttoSalary * (0.3090 + ChurchFee(tempProvince)));
                    NettoSalary = BruttoSalary - Tax;
                    break;
                case "Norrköping":
                    Tax = (int) (BruttoSalary * (0.3195 + ChurchFee(tempProvince)));
                    NettoSalary = BruttoSalary - Tax;
                    break;
            }
        }

        public string GetProvince()
        {
            switch (Province)
            {
                case 2:
                    return "Motala";
                case 3:
                    return "Linköping";
                case 4:
                    return "Norrköping";
                default:
                    return "Error";
            }
        }
    }
}