using UnityEngine;

/**
  Changes a sprite temporarily on an event.
**/
public class TempSpriteChanger : MonoBehaviour {
  public float changeTime;
  public Sprite tempSprite;

  private SpriteRenderer spriteRenderer;
  private Sprite previousSprite;

  void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
    previousSprite = spriteRenderer.sprite;
  }

  void HandleTempSpriteChange()
  {
    TempChangeSprite();
  }

  private void TempChangeSprite()
  {
    spriteRenderer.sprite = tempSprite;

    Invoke("RestoreSprite", changeTime);
  }

  private void RestoreSprite()
  {
    spriteRenderer.sprite = previousSprite;
  }
}
