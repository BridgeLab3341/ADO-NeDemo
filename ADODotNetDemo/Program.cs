namespace ADODotNetDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform the Operation\n1.Create DataBase\n3.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        CustomerOperations.CreateDataBase();
                        break;
                        case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}