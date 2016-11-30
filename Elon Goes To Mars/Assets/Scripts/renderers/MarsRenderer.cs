using UnityEngine;
using System.Collections;

/**
  Is responsible for rendering Mars and moving it to a Player.
  TODO: check if Update is called when not rendered (prob not)
  TODO: move the scene switch to another class or trigger an event.
**/
public class MarsRenderer : MonoBehaviour {
  public GameObject marsPrefab;
  public float startingX;
  public float startingY;
  public float finishX;
  public float speed = 10.0f;

  private bool movingLeft = false;
  private GameObject mars;
  private Vector3 target;
  private GameObject mainController;
  private SceneSwitcher sceneSwitcher;

  public MarsRenderer(GameObject passedMarsPrefab)
  {
    marsPrefab = passedMarsPrefab;
  }

  void Start()
  {
    target = new Vector3(finishX, startingY, 0);
    mainController = GameObject.FindWithTag("MainController");
    sceneSwitcher = mainController.GetComponent<SceneSwitcher>();
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
        mars.transform.position, target, step
      );

      if(Vector3.Distance(mars.transform.position, target) < 0.1f)
      {
        movingLeft = false;
        StartCoroutine(LoadVictoryScene());
      }
    }
  }

  IEnumerator LoadVictoryScene()
  {
    yield return new WaitForSecondsRealtime(1.5f);
    sceneSwitcher.SwitchScene("Victory");
  }
}
