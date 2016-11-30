using UnityEngine;
using UnityEngine.UI;

/**
  Binds the text to a Survivors value. Updates it when changed.
**/
public class SurvivorsController : MonoBehaviour {
  public Text scoreText;

  void Start()
  {
    updateSurvivorsText(ApplicationModel.survivors);
  }

  private void updateSurvivorsText(int newScore)
  {
    scoreText.text = newScore.ToString();
  }
}
