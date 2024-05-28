namespace taskmini11
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List<Classroom> classrooms = new List<Classroom>();

            static void Main()
            {
                bool running = true;

                while (running)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Sinif yarat");
                    Console.WriteLine("2. Telebe yarat");
                    Console.WriteLine("3. Butun Telebeleri ekrana cixar");
                    Console.WriteLine("4. Secilmis sinifdeki telebeleri ekrana cixar");
                    Console.WriteLine("5. Telebe sil");
                    Console.WriteLine("6. Cixis");
                    Console.WriteLine("Secim edin:");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CreateClassroom();
                            break;
                        case 2:
                            CreateStudent();
                            break;
                        case 3:
                            DisplayAllStudents();
                            break;
                        case 4:
                            DisplayStudentsInClassroom();
                            break;
                        case 5:
                            RemoveStudent();
                            break;
                        case 6:
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Duzgun secim et.");
                            break;
                    }
                }
            }

            static void CreateClassroom() { }
            

            static void CreateStudent() { }
           

            static void DisplayAllStudents() { }
            

            static void DisplayStudentsInClassroom() { }
        

            static void RemoveStudent() { }
            
        }

    }
}

