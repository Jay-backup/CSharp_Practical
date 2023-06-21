using System;

namespace Account
{
    internal class CustomerAccount
    {
        public string bankName;
        public string customerName;
        private long customerAccountNo;

        public long CustomerAccountNo
        {
            get { return customerAccountNo; }
            set
            {
                if(value.ToString().Length <= 10 || value.ToString().Length >= 12)
                {
                    throw new InvalidDataException("Acoount number is not valid");
                }
                else
                {
                    customerAccountNo = value;
                }
            }
        }
       

        public CustomerAccount(long accountNo, string aCustomerName)
        {
            this.CustomerAccountNo = accountNo;
            this.customerName = aCustomerName;
        }
        public void printInfo()
        {
            Console.WriteLine($"Bank name is: {bankName}");
            Console.WriteLine($"Customer Account number is: {customerAccountNo}");
            Console.WriteLine($"Customer Name is: {customerName}");

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                CustomerAccount ca = new CustomerAccount(47767687688, "Jay Gohel");
                ca.bankName = "SBI";
                ca.printInfo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

