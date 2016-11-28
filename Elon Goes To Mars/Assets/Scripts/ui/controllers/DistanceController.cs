using UnityEngine;
using UnityEngine.UI;

/**
  Binds the text field to a Distance. Updates it when changed.
**/
public class DistanceController : MonoBehaviour {
  public Text distanceText;
  public DistanceToMars distanceScript;

  void Start()
  {
    updateDistanceText(distanceScript.distance);
  }

  public void HandleDistanceChange(int newDistance)
  {
    updateDistanceText(newDistance);
  }

  private void updateDistanceText(int newDistance)
  {
    distanceText.text = newDistance.ToString() + " Mm";
  }
}
