using System.Globalization;

namespace Interface.Entities
{
    internal class Invoice
    {
        public double BasciPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basciPayment, double tax)
        {
            BasciPayment = basciPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasciPayment + Tax; }
        } 

        public override string ToString()
        {
            return "Basic payment"
                + BasciPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "/nTax:"
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "/nTotal payment:"
                + TotalPayment.ToString(CultureInfo.InvariantCulture);
        }
    }
}
