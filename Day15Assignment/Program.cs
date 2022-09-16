
namespace Day15Assignment
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter choice\n1.find ferquency of word\n2.find ferquency of phrase");
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
                    case 2:
                    MyMapNode<string, string> hash1 = new MyMapNode<string, string>(15);
                    hash1.Add("0", "Paranoids");
                    hash1.Add("1", "are");
                    hash1.Add("2", "not");
                    hash1.Add("3", "paranoid");
                    hash1.Add("4", "because");
                    hash1.Add("5", "they");
                    hash1.Add("6", "are");
                    hash1.Add("7", "paranoid");
                    hash1.Add("8", "but");
                    hash1.Add("9", "because");
                    hash1.Add("10", "they");
                    hash1.Add("11", "keep");
                    hash1.Add("12", "putting");
                    hash1.Add("13", "themselves");
                    hash1.Add("14", "delibrately");
                    hash1.Add("15", "into");
                    string hash15 = hash1.Get("15");
                    Console.WriteLine("15th index value: " + hash15);
                    break;


            }
        }
    }
}