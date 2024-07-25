using System;

namespace Events
{
  public class AudioSystem
  {
    public AudioSystem()
    {
      GameEventManager.OnGameStart += StartGame;
      GameEventManager.OnGameOver += GameOver;
    }

    private void StartGame()
    {
      Console.WriteLine("Audio System Started");
    }

    private void GameOver()
    {
      Console.WriteLine("Audio System Stopped");
    }
  }
}
