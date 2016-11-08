using UnityEngine;

/**
  Stores the Score value and dispatches an event on it's change.
**/
public class MainScore : MonoBehaviour {
  private int _score = 1000;

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

      SendMessage("HandleScoreChange", _score);
    }
  }
}
