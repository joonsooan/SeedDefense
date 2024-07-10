using UnityEngine;

public class Tile : MonoBehaviour
{
    public void PlacePlant(GameObject plant)
    {
        Debug.Log($"Plant placed on tile at position: {transform.position}");
    }

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
}
