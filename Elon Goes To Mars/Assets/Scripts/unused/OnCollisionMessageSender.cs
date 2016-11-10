using UnityEngine;

/**
  On collision enter sends a message.
**/
public class OnCollisionMessageSender: MonoBehaviour {
  public string collisionTag;

  void OnCollisionEnter2D(Collision2D other)
  {
    if(other.gameObject.CompareTag(collisionTag))
    {
      SendMessage("HandleCollisionHit");
    }
  }
}
