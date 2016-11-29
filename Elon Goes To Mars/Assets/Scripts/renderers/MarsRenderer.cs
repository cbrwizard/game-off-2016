using UnityEngine;

/**
  Is responsible for rendering Mars and moving it to a Player.
**/
public class MarsRenderer : MonoBehaviour {
  public GameObject marsPrefab;
  public float firstSpawn = 2.0f;
  public float spawnFrequency = 1.5f;
  public float startingX;
  public float startingYFrom;
  public float startingYTo;
  public int destroyAfterSeconds;

  public MarsRenderer(GameObject passedMarsPrefab)
  {
    marsPrefab = passedMarsPrefab;
  }

  void Start()
  {
    InvokeRepeating("render", firstSpawn, spawnFrequency);
  }

  public void StopSpawning()
  {
    CancelInvoke("render");
  }

  public void render()
  {
    GameObject mars = (GameObject)Instantiate(
      marsPrefab,
      new Vector3(startingX, Random.Range (startingYFrom, startingYTo), 0),
      Quaternion.identity
    );

    mars.SendMessage("HandleDestroyOnDelayStart", destroyAfterSeconds);
  }
}
