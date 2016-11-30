using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class DistanceChangeEvent : UnityEvent<int> {}

/**
  Stores the Distance value and dispatches an event on it's change.
**/
public class DistanceToMars : MonoBehaviour {
  public DistanceChangeEvent distanceChangeEvent;

  public int distance
  {
    get {
      return _distance;
    }
    set
    {
      if (value < 0) {
        _distance = 0;
      } else {
        _distance = value;
      }

      distanceChangeEvent.Invoke(_distance);
    }
  }

  private int _distance = 54600;

  void Start()
  {
    if (distanceChangeEvent == null)
    {
      distanceChangeEvent = new DistanceChangeEvent ();
    }
  }
}
