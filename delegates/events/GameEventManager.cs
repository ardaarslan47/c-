using System;

namespace Events
{
  public class GameEventManager
  {
     public delegate void GameEvent();

     public static event GameEvent OnGameStart, OnGameOver;

     public static void TriggerGameStart()
     {
       Console.WriteLine("Game Started");
       OnGameStart();
     }

     public static void TriggerGameOver()
     {
       Console.WriteLine("Game Over");
       OnGameOver();
     }
  }
}
