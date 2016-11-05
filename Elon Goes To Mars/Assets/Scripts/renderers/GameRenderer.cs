using UnityEngine;

/**
  Renders everything on a Game scene.
**/
public class GameRenderer {
  public void RenderInitialState ()
  {
    BackgroundRenderer backgroundRenderer = new BackgroundRenderer();
    backgroundRenderer.render();
  }
}
