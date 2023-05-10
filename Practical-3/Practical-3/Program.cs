public class Program
{
    public class Leptop
    {
        private string brand { get; set; }
        private string modal { get; set; }

        public Leptop(string aBrand, string aModal)
        {
            brand = aBrand;
            modal = aModal;
        }

        public void LeptopDetails()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Modal: " + modal);
        }
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }

        public static void Main(string[] args)
        {
            Leptop lep = new Leptop("HP", "Pavilion");
            lep.LeptopDetails();
            lep.MotherBoardInfo();
        }
    }
    
}
