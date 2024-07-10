using UnityEngine;
using UnityEngine.UI;

public class PlantButton : MonoBehaviour
{
    public Button button;
    public PlantType plantType; // 버튼이 선택할 식물 타입

    private void Start()
    {
        if (button == null)
        {
            button = GetComponent<Button>();
        }
        button.onClick.AddListener(() => PlantManager.Instance.SelectPlant(plantType));
    }
}
