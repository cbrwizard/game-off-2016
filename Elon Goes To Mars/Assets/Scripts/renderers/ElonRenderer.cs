using UnityEngine;

/**
  Renders a playable Elon object.
**/
public class ElonRenderer : MonoBehaviour {
  public GameObject elonPrefab;

  public ElonRenderer(GameObject passedElonPrefab)
  {
    elonPrefab = passedElonPrefab;
  }

  public void render()
  {
    Debug.Log("Rendering Elon");
    Instantiate(elonPrefab);
  }
}
