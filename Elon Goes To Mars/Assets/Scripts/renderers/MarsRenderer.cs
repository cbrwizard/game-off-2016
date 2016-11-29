using UnityEngine;

/**
  Is responsible for rendering Mars and moving it to a Player.
**/
public class MarsRenderer : MonoBehaviour {
  public GameObject marsPrefab;
  public float startingX;
  public float startingY;
  public float finishX;
  public float speed = 10.0f;

  private bool movingLeft = false;
  private GameObject mars;

  public MarsRenderer(GameObject passedMarsPrefab)
  {
    marsPrefab = passedMarsPrefab;
  }

  public void HandleWin()
  {
    render();
    startMovingLeft();
  }

  private void render()
  {
    mars = (GameObject)Instantiate(
      marsPrefab,
      new Vector3(startingX, startingY, 0),
      Quaternion.identity
    );
  }

  private void startMovingLeft()
  {
    movingLeft = true;
  }

  void Update() {
    if (movingLeft)
    {
      float step = speed * Time.unscaledDeltaTime;
      mars.transform.position = Vector3.MoveTowards(
        mars.transform.position, new Vector3(finishX, startingY, 0), step
      );
    }
  }
}
