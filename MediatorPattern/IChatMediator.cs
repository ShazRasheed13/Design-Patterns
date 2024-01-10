using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    // Mediator interface
    public interface IChatMediator
    {
        void SendMessage(User sender, string message);

    }

    public class ChatRoom : IChatMediator
    {
        private List<User> users = new List<User>();

        public void SendMessage(User sender, string message)
        {
            foreach (var user in users)
            {
                if (user != sender)
                {
                    user.Receive(message);
                }
            }
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }
    }
}
