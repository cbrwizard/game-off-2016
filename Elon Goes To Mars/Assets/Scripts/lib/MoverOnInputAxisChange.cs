using UnityEngine;
using System.Collections.Generic;

/**
  Moves an object on input axis change.
**/
public class MoverOnInputAxisChange : MonoBehaviour {
  public float speed;

  public void HandleInputAxisChange(Dictionary<string, float> axis)
  {
    Move(axis);
  }

  public void Move(Dictionary<string, float> axis)
  {
    Vector3 movement = new Vector3 (axis["Horizontal"], axis["Vertical"], 0);
    transform.position += movement * speed * Time.deltaTime;
  }
}
