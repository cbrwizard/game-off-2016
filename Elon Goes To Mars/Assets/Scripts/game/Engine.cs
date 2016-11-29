using UnityEngine;

/**
  Decreases distance every N secs.
**/
public class Engine : MonoBehaviour {
  public int kmPerMs = 10;

  private GameObject mainController;
  private DistanceToMars distanceToMars;

  void Start () {
    mainController = GameObject.FindWithTag("MainController");
    distanceToMars = mainController.GetComponent<DistanceToMars>();
  }

  void FixedUpdate()
  {
    DecreaseDistance();
  }

  private void DecreaseDistance()
  {
    distanceToMars.distance -= kmPerMs;
  }
}
