using UnityEngine;

/**
  Changes a sprite on an event.
**/
public class SpriteChanger : MonoBehaviour {
  public Sprite sprite;

  private SpriteRenderer spriteRenderer;

  void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }

  void HandleSpriteChange()
  {
    ChangeSprite();
  }

  private void ChangeSprite()
  {
    spriteRenderer.sprite = sprite;
  }
}
