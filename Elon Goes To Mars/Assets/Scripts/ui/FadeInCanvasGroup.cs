using UnityEngine;
// using System.Collections;

/**
  Is responsible for fading in a canvas group.
  TODO: make an actual fade in instead of toggle.
  TODO: add a proper delay.
**/
public class FadeInCanvasGroup : MonoBehaviour {
  public CanvasGroup canvasGroup;
  public float delayTime = 0f;


  public void Run()
  {
    // Debug.Log("in run!");
    // StartCoroutine(FadeIn());
    canvasGroup.alpha = 1;
    // Debug.Log("after cor in run!");
  }


  // IEnumerator FadeIn() {
  //   Debug.Log("in fade in!");
  //   if (delayTime > 0)
  //   {
  //     yield return new WaitForSeconds(delayTime);
  //   }
  //   Debug.Log("after wait!");
  //   canvasGroup.alpha = 1;
  // }
}
