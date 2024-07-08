using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPlant : PlantBase
{
    protected override void ProduceEffect()
    {
        ResourceManager.Instance.AddSeeds(1);
    }
}