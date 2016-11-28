using UnityEngine;
using System.Collections;

/**
  Is responsible for fading in a canvas group.
**/
public class FadeInCanvasGroup : MonoBehaviour {
  public CanvasGroup canvasGroup;
  public float delayTime;

  public void Run()
  {
    StartCoroutine(FadeIn());
  }

  IEnumerator FadeIn() {
    yield return new WaitForSecondsRealtime(delayTime);
    while (canvasGroup.alpha < 1.0f)
    {
      canvasGroup.alpha += 0.05f;
      yield return new WaitForSecondsRealtime(0.001f);
    }
  }
}
