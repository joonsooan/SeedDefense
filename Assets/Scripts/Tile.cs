using UnityEngine;

public class Tile : MonoBehaviour
{
    public GameObject currentPlant;

    void OnMouseDown()
    {
        Debug.Log("Tile clicked!");

        if (PlantManager.Instance != null)
        {
            PlantManager.Instance.PlacePlant(this);
            Debug.Log("Tile clicked and plant placed");
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
        Debug.Log($"PlacePlant() - Plant placed at {transform.position}");
    }
}
