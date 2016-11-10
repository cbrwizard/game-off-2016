using UnityEngine;

/**
  Handles a collision hit.
**/
public class CollisionHitHandler : MonoBehaviour {
  void HandleCollisionHit()
  {
    SendMessage("HandleTempSpriteChange");
    Debug.Log("received!");
  }
}
