using UnityEngine;

/**
  Renders everything on a Game scene.
**/
public class GameRenderer : MonoBehaviour {
  private ElonRenderer elonRenderer;

  public void RenderInitialState ()
  {
    elonRenderer = GetComponent<ElonRenderer>();
    elonRenderer.render();
  }
}
