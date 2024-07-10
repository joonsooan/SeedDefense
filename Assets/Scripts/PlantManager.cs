using UnityEngine;

public enum PlantType
{
    None,
    SeedPlant,
    WaterPlant,
    BuffPlant
}

public class PlantManager : MonoBehaviour
{
    public static PlantManager Instance;

    public GameObject[] plantPrefabs; // 여러 식물 프리팹 관리 배열
    public PlantType selectedPlant = PlantType.None; // 선택된 식물 타입

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SelectPlant(PlantType plantType)
    {
        selectedPlant = plantType;
        Debug.Log($"SelectPlant() - Selected Plant: {selectedPlant}");
    }

    public void PlacePlant(Tile tile)
    {
        Debug.Log($"PlacePlant() - Selected Plant: {selectedPlant}");

        if (selectedPlant != PlantType.None && tile != null)
        {
            GameObject selectedPrefab = plantPrefabs[(int)selectedPlant - 1]; // None이 인덱스 0이므로 -1 해줌
            Debug.Log($"Selected plant prefab: {selectedPrefab.name}");

            GameObject plant = Instantiate(selectedPrefab, tile.transform.position, Quaternion.identity);
            if (plant != null)
            {
                Debug.Log($"Plant instantiated successfully at: {tile.transform.position}");
                tile.PlacePlant(plant);
            }
            else
            {
                Debug.LogError("Failed to instantiate plant prefab!");
            }

            // selectedPlant = PlantType.None; // 한 번 배치한 후 선택 해제
        }
        else
        {
            if (selectedPlant == PlantType.None)
            {
                Debug.LogWarning("No plant selected");
            }
            if (tile == null)
            {
                Debug.LogWarning("Tile is null");
            }
        }
    }
}