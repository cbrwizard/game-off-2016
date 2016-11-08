using UnityEngine;
using UnityEngine.UI;

/**
  Binds the text field to a Score. Updates it when changed.
**/
public class ScoreController : MonoBehaviour {
  public Text scoreText;
  public MainScore mainScoreScript;

  void Start()
  {
    updateScoreText(mainScoreScript.score);
  }

  public void HandleScoreChange(int newScore)
  {
    updateScoreText(newScore);
  }

  private void updateScoreText(int newScore)
  {
    scoreText.text = newScore.ToString();
  }
}
