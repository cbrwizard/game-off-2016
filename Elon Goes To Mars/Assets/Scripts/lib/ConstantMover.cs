using UnityEngine;

/**
  Constantly moves a GameObject at a constant speed to a certain direction.
  TODO: accept a direction as a param.
**/
public class ConstantMover : MonoBehaviour {
  public float speed;

  void Update()
  {
    transform.Translate(Vector3.left * speed * Time.deltaTime);
  }

  void HandleConstantMoverSpeedChange(float newSpeed)
  {
    speed = newSpeed;
  }
}
