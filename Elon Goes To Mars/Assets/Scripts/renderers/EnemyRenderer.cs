using UnityEngine;

/**
  Renders an Enemy every certain period of time.
  TODO: create a smart algorithm for coordinates so that
  they're selected more scatteredly.
**/
public class EnemyRenderer : MonoBehaviour {
  public GameObject enemyPrefab;
  public float firstSpawn = 2.0f;
  public float spawnFrequency = 1.5f;

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
      new Vector3(9.0f, Random.Range (-4.0f, 4.0f), 0),
      Quaternion.identity
    );

    enemy.SendMessage("HandleDestroyOnDelayStart", 5);
  }
}
