using UnityEngine;

/**
  Is responsible for starting a movie.
  TODO: make it invoke a finish event; add a controller and invoke a scene switch somewhere.
**/
public class MovieStarter : MonoBehaviour {

  public string sceneToSwitch;
  private MovieTexture movieTexture;
  private SceneSwitcher sceneSwitcher;

  void Start () {
    movieTexture = ((MovieTexture)GetComponent<Renderer>().material.mainTexture);
    sceneSwitcher = GetComponent<SceneSwitcher>();
    movieTexture.Play();
  }

  void Update () {
    if(!movieTexture.isPlaying){
      sceneSwitcher.SwitchScene(sceneToSwitch);
    }
  }
}
