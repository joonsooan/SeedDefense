using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private PlantBase currentPlant;

    private void OnMouseDown()
    {
        if (currentPlant == null)
        {
            PlacePlant();
        }
    }

    private void PlacePlant()
    {
        // 여기서 식물 프리팹을 생성하여 배치합니다.
        // 예를 들어, SeedPlant 프리팹을 배치하려면:
        GameObject plantPrefab = Resources.Load<GameObject>("SeedPlant"); // 식물 프리팹을 Resources 폴더에서 로드합니다.
        if (plantPrefab != null)
        {
            GameObject plantInstance = Instantiate(plantPrefab, transform.position, Quaternion.identity);
            currentPlant = plantInstance.GetComponent<PlantBase>();
        }
    }
}