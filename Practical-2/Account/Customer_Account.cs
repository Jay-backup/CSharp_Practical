using System;

namespace Account
{
    internal class Customer_Account
    {
        public string bank_name;
        public string customer_name;
        private long customer_accountNo;

        public long Customer_accountNo
        {
            get { return customer_accountNo; }
            set
            {
                if(value.ToString().Length <= 10 || value.ToString().Length >= 12)
                {
                    throw new InvalidDataException("Acoount number is not valid");
                }
                else
                {
                    customer_accountNo = value;
                }
            }
        }
       

        public Customer_Account(long accountNo, string aCustomer_name)
        {
            this.Customer_accountNo = accountNo;
            this.customer_name = aCustomer_name;
        }
        public void printInfo()
        {
            Console.WriteLine($"Bank name is: {bank_name}");
            Console.WriteLine($"Customer Account number is: {customer_accountNo}");
            Console.WriteLine($"Customer Name is: {customer_name}");

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Customer_Account ca = new Customer_Account(47767687688, "Jay Gohel");
                ca.bank_name = "SBI";
                ca.printInfo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

