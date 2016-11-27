using UnityEngine;

/**
  Renders an Enemy every certain period of time.
  TODO: create a smart algorithm for coordinates so that
  they're selected more scatteredly.
  TODO: create a smart algorithm so that the enemies cannot be spawned
  too close to each other.
**/
public class EnemyRenderer : MonoBehaviour {
  public GameObject enemyPrefab;
  public float firstSpawn = 2.0f;
  public float spawnFrequency = 1.5f;
  public float startingX;
  public float startingYFrom;
  public float startingYTo;
  public int destroyAfterSeconds;

  public EnemyRenderer(GameObject passedEnemyPrefab)
  {
    enemyPrefab = passedEnemyPrefab;
  }

  void Start()
  {
    InvokeRepeating("render", firstSpawn, spawnFrequency);
  }

  public void render()
  {
    GameObject enemy = (GameObject)Instantiate(
      enemyPrefab,
      new Vector3(startingX, Random.Range (startingYFrom, startingYTo), 0),
      Quaternion.identity
    );

    enemy.SendMessage("HandleDestroyOnDelayStart", destroyAfterSeconds);
  }
}
