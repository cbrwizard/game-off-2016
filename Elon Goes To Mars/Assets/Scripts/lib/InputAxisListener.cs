using UnityEngine;
using System.Collections.Generic;

/**
  Listens to axis input events and calls functions on them.
**/
public class InputAxisListener : MonoBehaviour {
  private Dictionary<string, float> axis;
  void FixedUpdate()
  {
    DetectInputAxisChange();
  }

  private void DetectInputAxisChange()
  {
    float horizontalAxis = Input.GetAxis ("Horizontal");
    float verticalAxis = Input.GetAxis ("Vertical");

    if (horizontalAxis != 0 || verticalAxis != 0)
    {
      axis = new Dictionary<string, float>()
      {
        { "Horizontal", horizontalAxis },
        { "Vertical", verticalAxis },
      };

      DispatchInputAxisChange(axis);
    }
  }

  private void DispatchInputAxisChange(Dictionary<string, float> axis)
  {
    SendMessage("HandleInputAxisChange", axis);
  }
}
