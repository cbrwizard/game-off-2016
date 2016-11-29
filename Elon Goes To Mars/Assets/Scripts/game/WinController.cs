using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class WinEvent : UnityEvent {}

/**
  Is responsible for initiating a Win sequence when needed.
**/
public class WinController: MonoBehaviour {
  public WinEvent winEvent;
  public int winDistance = 0;

  private bool invoked = false;

  void Start()
  {
    if (winEvent == null)
    {
      winEvent = new WinEvent ();
    }
  }

  public void HandleDistanceChange(int distance)
  {
    if (distance <= winDistance && !invoked)
    {
      winEvent.Invoke();
      invoked = true;
    }
  }
}
