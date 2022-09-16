
namespace Day15Assignment
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter choice\n1.find ferquency of word");
            int opt =Convert.ToInt32 ( Console.ReadLine());

            switch(opt)
            {
                case 1:
                    MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
                    hash.Add("0", "To");
                    hash.Add("1", "be");
                    hash.Add("2", "or");
                    hash.Add("3", "not");
                    hash.Add("4", "To");
                    hash.Add("5", "be");


                    string hash5 = hash.Get("5");
                    string hash4 = hash.Get("4");
                    string hash3 = hash.Get("3");
                    string hash2 = hash.Get("2");
                    
                    Console.WriteLine("5th Index Value: " + hash5);
                    Console.WriteLine("4th Index Value: " + hash4);
                    Console.WriteLine("3th Index Value: " + hash3);
                    Console.WriteLine("2th Index Value: " + hash2);
                    break;
            }
        }
    }
}