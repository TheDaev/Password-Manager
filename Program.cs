namespace passwordmanager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "setpass")
            {
                File.WriteAllText($"passfor{args[1]}.passarg", args[2]);
                Console.WriteLine($"Password for {args[1]} has been created successfully!");
                Console.ReadLine();
            }
            else if (args[0] == "seepass")
            {
                
                if (File.Exists($"passfor{args[1]}"))
                {
                    string idk = File.ReadAllText($"passfor{args[1]}");
                    Console.WriteLine($"The password for {args[1]} is {idk}");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Password for {args[1]} not found");
                }
            }else if (args[0] == "seeall")
            {
                string directoryPath = @"C:\MyDirectory\*.passarg";
                string[] fileEntries = Directory.GetFiles(directoryPath);
                foreach (string obj in fileEntries)
                {
                    Console.WriteLine($"Website: {obj}\nPassword: {File.ReadAllText(obj)}\n---------------");
                }
            }
        }
    }
}
