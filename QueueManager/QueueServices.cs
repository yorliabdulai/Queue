using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueManager
{
    public class QueueServices
    {
        private readonly List<User> userList;
        public QueueServices()
        {
            userList = new List<User>();
        }
        public void EnqueueUser(string userName)
        {
            User user = new User { Name = userName};
            userList.Add(user);
            Console.WriteLine($"Welcome, {userName}! Your queue number is: {userList.Count + 1}");
        }
    }
}
