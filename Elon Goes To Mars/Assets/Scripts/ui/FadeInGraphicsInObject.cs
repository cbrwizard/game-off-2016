using UnityEngine;
using UnityEngine.UI;

/**
  Is responsible for fading in all graphics of an object.
  TODO: actually let the player look at the failure and only then display the text
  and then 1-2 secs later display the buttons.
**/
public class FadeInGraphicsInObject : MonoBehaviour {
  public GameObject graphicsParent;
  public float speed;


  public void Run()
  {
    foreach (Graphic graphic in graphicsParent.GetComponentsInChildren<Graphic>())
  {
      graphic.CrossFadeAlpha(250, speed, true);
    }
  }
}
