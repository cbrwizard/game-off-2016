using UnityEngine;

/**
  Initiates everything on a Game scene.
**/
public class GameStarter : MonoBehaviour {
  void Start () {
    GameRenderer gameRenderer = new GameRenderer();

    gameRenderer.RenderInitialState();
  }
}
