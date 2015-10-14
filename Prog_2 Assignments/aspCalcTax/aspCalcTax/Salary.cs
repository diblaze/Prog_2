using System.Runtime.InteropServices.ComTypes;

namespace aspCalcTax
{
    internal class Salary
    {
        public bool ChurchMember { get; set; }
        public int BruttoSalary { get; set; }
        public double ChurchTax { get; set; }
        public double FuneralTax { get; set; }
        public double LocalTax { get; set; }

        public double Net => BruttoSalary - Tax;

        public double Tax => BruttoSalary * (LocalTax + Fees());

        private double Fees()
        {
            if (ChurchMember)
            {
                return (FuneralTax + ChurchTax);
            }
            else
            {
                return FuneralTax;
            }
        }
    }
}