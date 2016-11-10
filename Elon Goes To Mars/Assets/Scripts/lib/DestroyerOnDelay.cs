using UnityEngine;

/**
  Destroyes a GameObject after receiving an event after certain delay.
**/
public class DestroyerOnDelay : MonoBehaviour {
  public void HandleDestroyOnDelayStart(int destroyDelay)
  {
    DestroyOnDelay(destroyDelay);
  }

  public void DestroyOnDelay(int destroyDelay)
  {
    Destroy (gameObject, destroyDelay);
  }
}
