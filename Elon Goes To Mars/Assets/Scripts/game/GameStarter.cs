using UnityEngine;

/**
  Initiates everything on a Game scene.
**/
public class GameStarter : MonoBehaviour {
  private GameRenderer gameRenderer;

  void Start () {
    gameRenderer = GetComponent<GameRenderer>();
    gameRenderer.RenderInitialState();
  }
}
