using UnityEngine;

public class Tile : MonoBehaviour
{
    public GameObject currentPlant;

    private void OnMouseDown()
    {
        Debug.Log("Tile clicked!");

        if (PlantManager.Instance != null)
        {
            PlantManager.Instance.PlacePlant(this);
            Debug.Log("Plant placement attempted after tile click");
        }
        else
        {
            Debug.LogWarning("PlantManager.Instance is null!");
        }
    }

    public void PlacePlant(GameObject plant)
    {
        if (currentPlant != null)
        {
            Destroy(currentPlant);
        }

        currentPlant = plant;
        Debug.Log($"Plant placed on tile at position: {transform.position}");
    }
}
