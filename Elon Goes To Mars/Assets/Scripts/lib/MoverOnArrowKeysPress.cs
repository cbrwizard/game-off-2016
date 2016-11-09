using UnityEngine;

/**
  Moves an object on arrow keys press.
  An object must have a Rigidbody 2D.
  TODO: somehow separate into 2 class:
  1. ArrowKeysListener which detects a move and dispatches a isMovingHorizontally change.
  2. MoverOnDirectionChange which moves on a isMovingHorizontally change.
  FIXME:
    1. Change logic so that speed is /2 for x too when it should go diagonally.
**/
public class MoverOnArrowKeysPress : MonoBehaviour {
  public float speed;
  private Rigidbody2D rb2D;

  void Start()
  {
    rb2D = GetComponent<Rigidbody2D>();
  }

   void FixedUpdate()
  {
    Move();
  }

  private void Move()
  {
    float newX = 0;
    float newY = 0;
    bool isMovingHorizontally = false;

    if(Input.GetKey(KeyCode.RightArrow))
    {
      isMovingHorizontally = true;
      newX += HorizontalPosition();
    }

    if(Input.GetKey(KeyCode.LeftArrow))
    {
      isMovingHorizontally = true;
      newX -= HorizontalPosition();
    }

    if(Input.GetKey(KeyCode.UpArrow))
    {
      newY += VerticalPosition(isMovingHorizontally);
    }

    if(Input.GetKey(KeyCode.DownArrow))
    {
      newY -= VerticalPosition(isMovingHorizontally);
    }

    rb2D.MovePosition(rb2D.position + new Vector2(newX, newY));
  }

  private float HorizontalPosition()
  {
    return speed * Time.deltaTime;
  }

  private float VerticalPosition(bool isMovingHorizontally)
  {
      float appliedSpeed = speed;
      if (isMovingHorizontally)
      {
        appliedSpeed /= 2;
      }
      return appliedSpeed * Time.deltaTime;
  }
}
