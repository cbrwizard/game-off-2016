using UnityEngine;

/**
  Handles a collision hit for Enemy.
**/
public class EnemyCollisionHitHandler : MonoBehaviour {
  public int destroyDelay;
  public int newSpeed;

  void HandleCollisionHit()
  {
    SendMessage("HandleSpriteChange");
    SendMessage("HandleDestroyOnDelayStart", destroyDelay);
    SendMessage("HandleConstantMoverSpeedChange", newSpeed);
  }
}
