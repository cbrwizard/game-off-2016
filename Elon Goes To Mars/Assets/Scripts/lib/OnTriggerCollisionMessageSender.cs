using UnityEngine;

/**
  On trigger collision stay sends a message to both objects.
**/
public class OnTriggerCollisionMessageSender: MonoBehaviour {
  public string collisionTag;

  void OnTriggerEnter2D(Collider2D other)
  {
    if(other.CompareTag(collisionTag))
    {
      SendMessage("HandleCollisionHit");
      other.gameObject.SendMessage("HandleCollisionHit", null, SendMessageOptions.DontRequireReceiver);
    }
  }
}
