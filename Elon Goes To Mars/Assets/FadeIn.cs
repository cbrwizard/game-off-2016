using UnityEngine;
using UnityEngine.UI;

/**
  Is responsible for fading in an object.
**/
public class FadeIn : MonoBehaviour {
  public Graphic graphicToFade;
  public float speed;

  public void Run()
  {
    graphicToFade.CrossFadeAlpha(250, speed, true);
  }
}
