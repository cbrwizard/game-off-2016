using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {
  public void SwitchScene(string sceneName)
  {
    if (sceneName == "Current")
    {
      Scene loadedLevel = SceneManager.GetActiveScene ();
      SceneManager.LoadScene (loadedLevel.buildIndex);
    }
    else
    {
      SceneManager.LoadScene(sceneName);
      Scene scene = SceneManager.GetSceneByName(sceneName);

      SceneManager.SetActiveScene(scene);
    }
  }
}
