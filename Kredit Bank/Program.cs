namespace Kredit_Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double umumiqiymet = 0, ayliqqiymet = 0, qaliq = 0, sonqiymet = 0;
        tryagain:
            Console.WriteLine("Please enter the username");
            string admin = Console.ReadLine();

            Console.WriteLine("Enter the password");
            string str = Console.ReadLine();
            bool dadmin = true;
            bool dpassword = true;


            if (str  != "admin")
            {
                Console.WriteLine("Please try again");
                goto tryagain;

            }
            if (str != "password")
            {
                Console.WriteLine("Successful login");
            }

            else
            { Console.WriteLine("Zehmet olmasa seciminizi bildirin"); }
            Console.WriteLine("1 Kredit Götürmek");
            Console.WriteLine("2 Kredit Ödemek");
            Console.WriteLine("3 Hesabat");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Xahis olunur ayi daxil edin");
                    int ay = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kredit goturmek istediyiniz meblegi daxil edin");
                    double mebleg = int.Parse(Console.ReadLine());
                    if (ay <= 12)
                    {
                        umumiqiymet = mebleg + (mebleg * 0.12);
                        ayliqqiymet = umumiqiymet / ay;
                        Console.WriteLine("Yekun odenilecek mebleg" + umumiqiymet);
                        Console.WriteLine("Ayliq odenilecek mebleg" + ayliqqiymet);
                        double qaliq1 = umumiqiymet - ayliqqiymet;
                        break;





                    }
                    else if (ay > 12)
                    {
                        umumiqiymet = mebleg + (mebleg * 0.18);
                        ayliqqiymet = umumiqiymet / ay;
                        Console.WriteLine("Yekun odenilecek mebleg" + umumiqiymet);
                        Console.WriteLine("Ayliq odenilecek mebleg" + umumiqiymet / (ay * 0.18));
                    }

                    break;
                    
                

                   

                   

                    

                   
                    

                        
                          
                        
                   
                    
            
            }



            

            
                



             

              
            


            





        }
    }
}