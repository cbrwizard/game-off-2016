using UnityEngine;

/**
  Stops on a collision with a wall (must have Is Trigger).
**/
public class OnWallCollisionStopper: MonoBehaviour {
  public string wallTag;

 void OnTriggerEnter2D(Collider2D other)
 {
    if(other.CompareTag(wallTag))
    {
      Debug.Log("trigger hit a wall!");
        // rigidbody.velocity = Vector3.zero;
    }
 }
}
