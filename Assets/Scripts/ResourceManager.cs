using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance { get; private set; }

    public int seedCount;
    public int waterCount;

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

    // 씨앗을 추가하는 메서드
    public void AddSeeds(int amount)
    {
        seedCount += amount;
        Debug.Log($"Current Seed: {seedCount}");
        // 씨앗 추가 로직
    }

    // 물을 추가하는 메서드
    public void AddWater(int amount)
    {
        waterCount += amount;
        // 물 추가 로직
    }

    // 씨앗을 사용하는 메서드
    public bool UseSeeds(int amount)
    {
        if (seedCount >= amount)
        {
            seedCount -= amount;
            return true;
        }
        return false;
    }

    // 물을 사용하는 메서드
    public bool UseWater(int amount)
    {
        if (waterCount >= amount)
        {
            waterCount -= amount;
            return true;
        }
        return false;
    }
}
