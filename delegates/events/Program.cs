using System;

namespace Events
{
  class Program
  {
    static void Main()
    {
      AudioSystem audioSystem = new AudioSystem();
      RenderingEngine renderingEngine = new RenderingEngine();

      Player player1 = new Player("Arda");     
      Player player2 = new Player("Azize");     

      GameEventManager.TriggerGameStart();
      Console.WriteLine("Game is running press any key to end");

      Console.Read();

      GameEventManager.TriggerGameOver();
    }
  }
}
