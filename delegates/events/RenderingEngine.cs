using System;

namespace Events
{
  public class RenderingEngine
  {
    public RenderingEngine()
    {
      GameEventManager.OnGameStart += StartGame;
      GameEventManager.OnGameOver += GameOver;
    }
    
    private void StartGame()
    {
      Console.WriteLine("Rendering Engine Started");
    }

    private void GameOver()
    {
      Console.WriteLine("Rendering Engine Stopped");
    }

  }


}
