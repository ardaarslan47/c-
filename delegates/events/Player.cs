using System;

namespace Events
{
  public class Player
  {
    public string PlayerName {get; set;}

    public Player(string name)
    {
      this.PlayerName = name;
      GameEventManager.OnGameStart += StartGame;
      GameEventManager.OnGameOver += GameOver;
    }

    private void StartGame()
    {
      Console.WriteLine($"Spawning player with ID: {PlayerName}");
    }

    private void GameOver()
    {
      Console.WriteLine($"Removing player with ID: {PlayerName}");
    }
  } 
}
