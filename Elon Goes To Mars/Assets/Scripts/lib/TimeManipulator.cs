using UnityEngine;

/**
  Handles time manipulation.
**/
public class TimeManipulator : MonoBehaviour {
  public void SlowDownAlmostCompletely()
  {
    Time.timeScale = 0.1f;
    UpdateFixedDeltaTime();
  }

  public void RestoreTime()
  {
    Time.timeScale = 1.0f;
    UpdateFixedDeltaTime();
  }

  private void UpdateFixedDeltaTime()
  {
    Time.fixedDeltaTime = 0.02F * Time.timeScale;
  }
}
