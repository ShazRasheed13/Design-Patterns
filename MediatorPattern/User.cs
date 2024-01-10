using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    // Colleague interface
    public abstract class User
    {
        protected IChatMediator mediator;
        protected string name;

        public User(IChatMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }

    // Concrete colleague
    public class BasicUser : User
    {
        public BasicUser(IChatMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("Basic user " + name + " sends: " + message);
            mediator.SendMessage(this, message);
        }

        public override void Receive(string message)
        {
            Console.WriteLine("Basic user " + name + " received: " + message);
        }
    }

    // Concrete colleague
    public class PremiumUser : User
    {
        public PremiumUser(IChatMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("Premium user " + name + " sends: " + message);
            mediator.SendMessage(this, message);
        }

        public override void Receive(string message)
        {
            Console.WriteLine("Premium user " + name + " received: " + message);
        }
    }
}
