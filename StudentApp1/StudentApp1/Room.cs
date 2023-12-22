using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp1
{
    public class Room
    {
        private int taskIdCounter = 1;
        public int RoomNumber { get; set; }
        public List<User> Users { get; set; } = new List<User>();

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }
        public void Register(User user)
        {
            Users.Add(user);
        }
        public void AssignTasksRandomly()
        {
            Random random = new Random();

            foreach (User user in Users)
            {
                Console.WriteLine($"Assigning tasks for user {user.Name}, Room: {RoomNumber}");

                foreach (TaskType task in Enum.GetValues(typeof(TaskType)))
                {
                    DateTime dateTime = DateTime.Now.AddDays(random.Next(1, 7));
                    Task newTask = new Task(taskIdCounter++, task.ToString(), dateTime, task);

                    // Ensure user.Tasks is initialized before adding tasks
                    if (user.Tasks == null)
                    {
                        user.Tasks = new List<Task>();
                    }

                    user.Tasks.Add(newTask);

                    Console.WriteLine($"Task assigned: {newTask.GetDescription()} for user {user.Name}");
                }
            }
        }
    }
}