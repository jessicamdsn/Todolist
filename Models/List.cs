namespace Todolist.Models
{
    public class List
    {
        private List<string> tasklList = new List<string>();

        public void AddTask()
        {
            Console.WriteLine("Type something to add to the list:");
            string typed = Console.ReadLine();
            tasklList.Add(typed);
        }

        public void RemoveTask()
        {
            if (tasklList.Any())
            {
                Console.WriteLine("Type what you want to remove from the list::");
                string task = Console.ReadLine();

                if (tasklList.Any())
                {
                    tasklList.Remove(task);

                    Console.WriteLine($"The task - {task} - was removed successfully");
                }
                else
                {
                    Console.WriteLine("Sorry, this task does not exist, please check if you type correctly");
                }
            }
            else
            {
                Console.WriteLine("there's no task in this list, so you can't remove any.");

            }
            // Verifica se o veículo existe

        }

        public void listTasks()
        {
            // Verifica se há veículos no estacionamento
            if (tasklList.Any())
            {
                Console.WriteLine("Your To do List is:");

                foreach (string item in tasklList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("there's not any task on this list");
            }
        }
    }
}