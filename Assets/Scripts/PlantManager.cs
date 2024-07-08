using UnityEngine;

public class PlantManager : MonoBehaviour
{
    public static PlantManager Instance;

    public GameObject[] plantPrefabs; // 배열로 여러 식물 프리팹을 관리
    private int selectedPlantIndex = -1; // 선택된 식물 인덱스

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SelectPlant(int plantIndex)
    {
        if (plantIndex >= 0 && plantIndex < plantPrefabs.Length)
        {
            selectedPlantIndex = plantIndex;
            Debug.Log("Selected plant: " + plantPrefabs[selectedPlantIndex].name);
        }
    }

    public void PlacePlant(Tile tile)
    {
        Debug.Log($"Selected Plant Index: {selectedPlantIndex}");

        if (selectedPlantIndex != -1 && tile != null)
        {
            GameObject selectedPrefab = plantPrefabs[selectedPlantIndex];
            Debug.Log("Selected plant prefab: " + selectedPrefab.name);

            GameObject plant = Instantiate(selectedPrefab, tile.transform.position, Quaternion.identity);
            if (plant != null)
            {
                Debug.Log("Plant instantiated successfully at: " + tile.transform.position);
                tile.PlacePlant(plant);
            }
            else
            {
                Debug.LogError("Failed to instantiate plant prefab!");
            }

            selectedPlantIndex = -1; // 한 번 배치한 후 선택 해제
        }
        else
        {
            Debug.LogWarning("No plant selected or tile is null");
        }
    }
}
