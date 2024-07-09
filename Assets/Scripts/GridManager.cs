using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [Header("Tile Settings")]
    [SerializeField] int width = 6;
    [SerializeField] int height = 5;
    [SerializeField] float tileSpacing = 1.2f; // 타일 간격
    [SerializeField] GameObject tilePrefab; // Tile Prefab
    [SerializeField] Color tileColor = Color.green; // 타일 색상 설정

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 position = new Vector3(x * tileSpacing, y * tileSpacing, 0);
                GameObject tile = Instantiate(tilePrefab, position, Quaternion.identity, transform);

                // 타일의 색상을 설정합니다.
                SpriteRenderer sr = tile.GetComponent<SpriteRenderer>();
                if (sr != null)
                {
                    sr.color = tileColor;
                }
            }
        }
    }
}
