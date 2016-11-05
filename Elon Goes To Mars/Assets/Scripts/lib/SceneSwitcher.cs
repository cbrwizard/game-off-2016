using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {
  public void SwitchScene(string sceneName)
  {
    SceneManager.LoadScene(sceneName);
    Scene scene = SceneManager.GetSceneByName(sceneName);

    SceneManager.SetActiveScene(scene);
  }
}
