using UnityEngine;

/**
  Moves an object on arrow keys press.
  TODO: somehow separate into 2 class:
  1. ArrowKeysListener which detects a move and dispatches a direction change.
  2. MoverOnDirectionChange which moves on a direction change.
**/
public class MoverOnArrowKeysPress : MonoBehaviour {
  public float speed;

   void Update()
  {
    Move();
  }

  private void Move()
  {
    Vector3 horizontalVector = new Vector3(speed * Time.deltaTime,0,0);
    Vector3 vericalVector = new Vector3(0,speed * Time.deltaTime,0);

    if(Input.GetKey(KeyCode.RightArrow))
    {
      transform.position += horizontalVector;
    }
    if(Input.GetKey(KeyCode.LeftArrow))
    {
      transform.position -= horizontalVector;
    }

    if(Input.GetKey(KeyCode.UpArrow))
    {
      transform.position += vericalVector;
    }
    if(Input.GetKey(KeyCode.DownArrow))
    {
      transform.position -= vericalVector;
    }
  }
}
