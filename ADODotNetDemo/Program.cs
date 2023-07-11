namespace ADODotNetDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform the Operation\n1.Create DataBase\n2.Create Table\n3.Insert Data\n4.Update\n5.Delete data\n6.Exit");
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
                        CustomerOperations.InsertData();
                        break;
                        case 4:
                        CustomerOperations.UpdateData();
                        break;
                        case 5:
                        CustomerOperations.Delete();
                        break;
                        case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}