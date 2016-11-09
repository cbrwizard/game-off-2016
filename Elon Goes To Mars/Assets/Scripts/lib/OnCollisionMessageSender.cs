using UnityEngine;

/**
  On trigger collision enter sends a message.
**/
public class OnCollisionMessageSender: MonoBehaviour {
  public string collisionTag;
  public string messageName;

  void OnTriggerEnter2D(Collider2D other)
  {
    if(other.CompareTag(collisionTag))
    {
      SendMessage(messageName);
    }
  }
}
