using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPlant : PlantBase
{
    protected override void ProduceEffect()
    {
        ResourceManager.Instance.AddWater(1); // ResourceManager에 AddWater 메서드가 있다고 가정합니다.
    }
}