using UnityEngine;

/**
  Handles a collision hit for Elon.
**/
public class ElonCollisionHitHandler : MonoBehaviour {
  public int decreaseScoreOnHit;

  private GameObject mainController;
  private MainScore mainScore;
  private DistanceToMars distanceToMars;
  private Animator animator;

  void Start()
  {
    animator = GetComponent<Animator>();
    mainController = GameObject.FindWithTag("MainController");
    mainScore = mainController.GetComponent<MainScore>();
    distanceToMars = mainController.GetComponent<DistanceToMars>();
  }

  void HandleCollisionHit()
  {
    animator.SetTrigger("Hit");
    DecreaseScore();
  }

  private void DecreaseScore()
  {
    mainScore.score -= decreaseScoreOnHit;
    distanceToMars.distance -= decreaseScoreOnHit * 100;
  }
}
