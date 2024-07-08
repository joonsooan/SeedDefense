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
        if (selectedPlantIndex != -1 && tile != null)
        {
            GameObject selectedPrefab = plantPrefabs[selectedPlantIndex];
            tile.PlacePlant(selectedPrefab);
            selectedPlantIndex = -1; // 한 번 배치한 후 선택 해제
        }
    }
}
