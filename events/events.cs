using System;

namespace Events
{
  public delegate void Notify(string message);

  public class EventPublisher
  {
    public event Notify OnNotify;

    public void RaiseEvent(string message)
    {
      OnNotify?.Invoke(message);
    }
  }

  public class EventSubscriber
  {
    public void OnEventRaised(string message)
    {
      Console.WriteLine("Event recieved: {0}", message);
    }
  }

  internal class Program
  {


    public static void Main()
    {
      EventPublisher publisher = new EventPublisher();
      EventSubscriber subscriber = new EventSubscriber();

      publisher.OnNotify += subscriber.OnEventRaised;

      publisher.RaiseEvent("Hello");
    }
  }
}
