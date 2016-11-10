using UnityEngine;
using System;

/**
  On trigger collision stay sends a message to both objects.
  TODO now: make time param optional
  The problem with this is that without a time param option
  this will trigger all the time because of OnTriggerStay2D
  being used instead of OnTriggerEnter2D. It's used because
  an object can be inside the other object when the timer is
  off.
**/
public class OnTriggerCollisionMessageSender: MonoBehaviour {
  // Should be the same as tmp sprite change time.
  public int debounceTime;
  public string collisionTag;
  private DateTime lastCollision;
  TimeSpan invincibleDuration;

  void Start()
  {
    debounceTime = 1;
    invincibleDuration = TimeSpan.FromSeconds(debounceTime);
    resetLastCollision();
  }

  void OnTriggerStay2D(Collider2D other)
  {
    if (timePassed() && other.CompareTag(collisionTag))
    {
      resetLastCollision();
      SendMessage("HandleCollisionHit");
      other.gameObject.SendMessage("HandleCollisionHit", null, SendMessageOptions.DontRequireReceiver);
    }
  }

  private bool timePassed()
  {
    return DateTime.UtcNow - lastCollision > invincibleDuration;
  }

  private void resetLastCollision()
  {
    lastCollision = DateTime.UtcNow;
  }
}
