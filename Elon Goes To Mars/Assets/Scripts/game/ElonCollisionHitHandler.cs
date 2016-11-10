using UnityEngine;

/**
  Handles a collision hit for Elon.
  FIXME: when a sprite is changed after time and Elon is still inside the enemy, the sprite does
  not change again for that enemy. Maybe this is okay.
  TODO: refactor it into a proper state.
**/
public class ElonCollisionHitHandler : MonoBehaviour {
  public int decreaseScoreOnHit;

  private GameObject mainController;
  private MainScore mainScore;

  void HandleCollisionHit()
  {
    SendMessage("HandleTempSpriteChange");
    DecreaseScore();
  }

  private void DecreaseScore()
  {
    mainController = GameObject.FindWithTag("MainController");
    mainScore = mainController.GetComponent<MainScore>();
    mainScore.score -= decreaseScoreOnHit;
  }
}
