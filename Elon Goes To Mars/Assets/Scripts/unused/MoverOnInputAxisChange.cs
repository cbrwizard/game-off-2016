using UnityEngine;
using System.Collections.Generic;

/**
  Moves an object on input axis change.
**/
public class MoverOnInputAxisChange : MonoBehaviour {
  public float speed;
  private Rigidbody2D rb;

  public void HandleInputAxisChange(Dictionary<string, float> axis)
  {
    Move(axis);
  }

  public void Move(Dictionary<string, float> axis)
  {
    rb = GetComponent<Rigidbody2D>();

    rb.AddForce(transform.up * axis["Vertical"] * speed * Time.deltaTime);
    rb.AddForce(transform.right * axis["Horizontal"] * speed * Time.deltaTime);
  }
}
