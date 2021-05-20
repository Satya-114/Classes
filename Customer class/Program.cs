using System;

namespace Class_customer
{
    class customer
    {
        static void main(string[] args)
        {

        public int CustID;
        public string Name;
        public string Address;


        customer()
        {
            CustID = 1101;
            Name = "Tom";
            Address = "USA";
        }


        public void displayData()
        {
            Console.WriteLine("Customer=" + CustID);
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Address=" + Address);
        }
    }
}


    


   
    
