using UnityEngine;

/**
  Renders a Collision every certain period of time.
**/
public class CollisionRenderer : MonoBehaviour {
  public GameObject collisionPrefab;
  public float firstSpawn = 2.0f;
  public float spawnFrequency = 1.5f;
  public int destroyTime = 10;

  public CollisionRenderer(GameObject passedCollisionPrefab)
  {
    collisionPrefab = passedCollisionPrefab;
  }

  void Start()
  {
    InvokeRepeating("render", firstSpawn, spawnFrequency);
  }

  public void render()
  {
    Object collision = Instantiate(
      collisionPrefab,
      new Vector3(9.0f, Random.Range (-4.0f, 4.0f), 0),
      Quaternion.identity
    );

    Destroy (collision, destroyTime);
  }
}
