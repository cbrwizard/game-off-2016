using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class DeathEvent : UnityEvent {}

/**
  Is responsible for controlling Death!
  Actually, is responsible for initiating a Death sequence when needed.
**/
public class DeathController: MonoBehaviour {
  public DeathEvent deathEvent;

  public int deathScore;

  void Start()
  {

    if (deathEvent == null)
    {
      deathEvent = new DeathEvent ();
    }
  }

  public void HandleScoreChange(int score)
  {
    if (score <= deathScore)
    {
      deathEvent.Invoke();
    }
  }
}
