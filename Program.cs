namespace Task_Tracker_Project
{
    internal class Program
    {
        static string[] tasks = new string[100];// array to store tasks
        static int taskCount = 0;// variable to add tasks with it and increase every task added
        static void Main(string[] args)
        {

        #region core app
            //welcome beek in our Application 
            //adding task
            //view tasks
            //delete task
            //update task
            //mark task as complete
            //exit application
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("___________welcome beek in our Application_______");

            while (true)
            {
               
               // Console.WriteLine("___________welcome beek in our Application_______");
                Console.WriteLine("enter number from 1 to 5 : \n1.Add Task\n2.View Task\n3.Delete Task\n4.Update Task\n5.Complete Task\n6.exist app");
                string ch = Console.ReadLine();
                Console.WriteLine("-------------------------------");

                switch (ch)
                {
                    case "1":
                        AddTask();
                        // Console.Clear(); // to clear the console
                        Console.WriteLine("-------------------------------");
                        break;
                    case "2":
                        Console.WriteLine("viewing tasks");
                        ViewTask();
                        Console.WriteLine("-------------------------------");

                        break;
                    case "3":
                        DeleteTask();
                        Console.WriteLine("-------------------------------");

                        break;
                    case "4":
                        UpdateTask();
                        Console.WriteLine("-------------------------------");

                        break;
                    case "5":
                        CompleteTask();
                        Console.WriteLine("-------------------------------");

                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        Console.WriteLine("-------------------------------");

                        break;
                }
          
            }
           
        }
            #endregion

        #region adding task
        private static void AddTask()
        {
            string c;
            do
            {
                Console.WriteLine("adding new task");
                tasks[taskCount] = Console.ReadLine();
                taskCount++;
                Console.WriteLine("task added successfully");
                Console.WriteLine("do you want to add another task? (y/n)");
                c = Console.ReadLine();
            }
            while (c == "y" || c == "Y");

        }
        #endregion
        #region view task
        private static void ViewTask()
        {
            if (taskCount == 0)
            {
                Console.WriteLine("U not have any tasks");
            }
            else
            {
                int newCount = 1;
                for (int i = 0; i < taskCount; i++)
                {
                    if (tasks[i] != null)
                    {
                        Console.WriteLine($"{newCount}.{tasks[i]}");
                        ++newCount;
                    }
                   
                }
            }
                
        }
        #endregion
        #region delete task
        private static void DeleteTask()
        {
            Console.WriteLine("Plz enter the Id of Task u want to delete it");
            int id = int.Parse(Console.ReadLine());
            tasks[id-1]=null; // id-1 => user will enter num from 1 no from zero
            Console.WriteLine("task deleted successfully");
        }
        #endregion
        #region update task
        private static void UpdateTask()
        {
            Console.WriteLine("enter the num of the task u want to Update");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the new task");
            tasks[id - 1] = Console.ReadLine();
            Console.WriteLine("task updated successfully");
        }
        #endregion
        #region complete task
        private static void CompleteTask()
        {
            Console.WriteLine("enter the no of task u want to mark it as completed");
            int id = int.Parse(Console.ReadLine());
            tasks[id - 1]+="--Completed";
            Console.WriteLine("task marks as completed");
        }
#endregion
    }
}

