using UnityEngine;

/**
  On trigger collision stay sends a message to both objects.
  TODO: make state param optional
**/
public class OnTriggerCollisionMessageSender: MonoBehaviour {
  public string collisionTag;
  public string ignoreStateName;
  private int ignoreState;
  private Animator animator;

  void Start()
  {
    ignoreState = Animator.StringToHash(ignoreStateName);
    animator = GetComponent<Animator>();
  }

  void OnTriggerStay2D(Collider2D other)
  {
    if (isCurrentStateIgnored() && other.CompareTag(collisionTag))
    {
      SendMessage("HandleCollisionHit");

      other.gameObject.SendMessage("HandleCollisionHit", null, SendMessageOptions.DontRequireReceiver);
    }
  }

  private bool isCurrentStateIgnored()
  {
    return animator.GetCurrentAnimatorStateInfo(0).shortNameHash != ignoreState;
  }
}
