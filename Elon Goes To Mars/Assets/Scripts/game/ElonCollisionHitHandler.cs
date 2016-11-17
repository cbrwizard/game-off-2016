using UnityEngine;

/**
  Handles a collision hit for Elon.
**/
public class ElonCollisionHitHandler : MonoBehaviour {
  public int decreaseScoreOnHit;

  private GameObject mainController;
  private MainScore mainScore;
  private Animator animator;

  void Start()
  {
    animator = GetComponent<Animator>();
    mainController = GameObject.FindWithTag("MainController");
    mainScore = mainController.GetComponent<MainScore>();
  }

  void HandleCollisionHit()
  {
    animator.SetTrigger("Hit");
    DecreaseScore();
  }

  private void DecreaseScore()
  {
    mainScore.score -= decreaseScoreOnHit;
  }
}
