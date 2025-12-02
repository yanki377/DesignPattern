using System;

namespace DesignPattern.Observer
{
    public class ConcreteObserver : IObserver // represents a user who wants to be notified
    // if the products availability change
    {
        public string UserName { get; }

        public ConcreteObserver(string userName)
        {
            UserName = userName;
        }

        public void AddSubscriber(ISubject subject)        // Subscribe the user to a product

        {
            subject.RegisterObserver(this);
        }

        public void RemoveSubscriber(ISubject subject)        // Unsubscribe the user

        {
            subject.RemoveObserver(this);
        }

        public void Update(string availability)        // Called by the Subject when availability changes

        {
            Console.WriteLine($"Hello {UserName}, the product is now {availability}");
        }
    }
}