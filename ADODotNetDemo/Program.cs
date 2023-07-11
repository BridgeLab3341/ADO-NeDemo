namespace ADODotNetDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform the Operation\n1.Create DataBase\n2.Create Table\n3.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        CustomerOperations.CreateDataBase();
                        break;
                        case 2:
                        CustomerOperations.CreateTable();
                            break;
                        case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}