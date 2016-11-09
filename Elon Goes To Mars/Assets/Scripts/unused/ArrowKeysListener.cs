using UnityEngine;
using System.Collections;

/**
  Listens to arrow presses and sends message about them.
**/
public class ArrowKeysListener : MonoBehaviour {
  private ArrayList pressedDirections = new ArrayList();
  void Update()
  {
    DetectArrowKeysPress();
  }

  private void DetectArrowKeysPress()
  {
    if(Input.GetKey(KeyCode.RightArrow))
    {
      pressedDirections.Add("right");
    }
    if(Input.GetKey(KeyCode.LeftArrow))
    {
      pressedDirections.Add("left");
    }
    if(Input.GetKey(KeyCode.DownArrow))
    {
      pressedDirections.Add("down");
    }
    if(Input.GetKey(KeyCode.UpArrow))
    {
      pressedDirections.Add("up");
    }

    DispatchDirectionChange(pressedDirections);
  }

  private void DispatchDirectionChange(ArrayList pressedDirections)
  {
    SendMessage("HandleDirectionChange", pressedDirections);
  }
}
