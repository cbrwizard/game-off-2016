using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class ScoreChangeEvent : UnityEvent<int> {}

/**
  Stores the Score value and dispatches an event on it's change.
**/
public class MainScore : MonoBehaviour {
  public ScoreChangeEvent scoreChangeEvent;

  public int score
  {
    get {
      return _score;
    }
    set
    {
      if (value < 0) {
        _score = 0;
      } else {
        _score = value;
      }

      scoreChangeEvent.Invoke(_score);
    }
  }

  private int _score = 1000;

  void Start()
  {
    if (scoreChangeEvent == null)
    {
      scoreChangeEvent = new ScoreChangeEvent ();
    }
  }
}
