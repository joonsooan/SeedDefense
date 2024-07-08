using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Color originalColor;
    public Color newColor;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            originalColor = spriteRenderer.color;
        }
    }

    void OnMouseDown()
    {
        Debug.Log("Tile clicked!");
        if (spriteRenderer != null)
        {
            // 클릭하면 타일의 색상을 바꿉니다.
            spriteRenderer.color = newColor;
        }
    }

    public void ResetColor()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = originalColor;
        }
    }
}
