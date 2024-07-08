using UnityEngine;

public class PlantManager : MonoBehaviour
{
    public static PlantManager Instance;

    public GameObject[] plantPrefabs; // 배열로 여러 식물 프리팹을 관리
    private GameObject selectedPlantPrefab;

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
            selectedPlantPrefab = plantPrefabs[plantIndex];
            Debug.Log("Selected plant: " + selectedPlantPrefab.name);
        }
    }

    public void PlacePlant(Tile tile)
    {
        if (selectedPlantPrefab != null && tile != null)
        {
            tile.PlacePlant(selectedPlantPrefab);
            selectedPlantPrefab = null; // 한 번 배치한 후 선택 해제
        }
    }
}
