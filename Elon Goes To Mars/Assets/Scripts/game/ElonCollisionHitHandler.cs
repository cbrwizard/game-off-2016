using UnityEngine;

/**
  Handles a collision hit for Elon.
  FIXME: when a sprite is changed after time and Elon is still inside the enemy, the sprite does
  not change again for that enemy. Maybe this is okay.
**/
public class ElonCollisionHitHandler : MonoBehaviour {
  void HandleCollisionHit()
  {
    SendMessage("HandleTempSpriteChange");
    Debug.Log("received!");
  }
}
