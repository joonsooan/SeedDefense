using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Color originalColor;
    public Color newColor;

    public GameObject currentPlant;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            originalColor = spriteRenderer.color;
        }
    }

    // 타일 클릭 시 색상 변경
    // void OnMouseDown()
    // {
    //     Debug.Log("Tile clicked!");

    //     if (spriteRenderer != null)
    //     {
    //         spriteRenderer.color = newColor;
    //     }

    //     // 선택된 식물을 타일에 배치
    //     PlantManager.Instance.PlacePlant(this);
    // }

    void OnMouseDown()
    {
        Debug.Log("Tile clicked!");

        // 선택된 식물을 타일에 배치
        PlantManager.Instance.PlacePlant(this);
    }

    public void PlacePlant(GameObject plantPrefab)
    {
        if (currentPlant == null)
        {
            currentPlant = Instantiate(plantPrefab, transform.position, Quaternion.identity);
            currentPlant.transform.SetParent(transform);
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
