using UnityEngine;

/**
  Handles a collision hit for Elon.
  FIXME: when a sprite is changed after time and Elon is still inside the enemy, the sprite does
  not change again for that enemy. Maybe this is okay.
  TODO: refactor it into a proper state.
**/
public class ElonCollisionHitHandler : MonoBehaviour {

  void HandleCollisionHit()
  {
    SendMessage("HandleTempSpriteChange");
    Debug.Log("received!");
  }
}
