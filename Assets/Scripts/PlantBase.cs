using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlantBase : MonoBehaviour
{
    // 효과를 발생시키는 주기
    public float effectInterval = 1.0f;

    private void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.gravityScale = 0;
        }

        StartCoroutine(Produce());
    }

    protected abstract void ProduceEffect();

    private IEnumerator Produce()
    {
        while (true)
        {
            yield return new WaitForSeconds(effectInterval);
            ProduceEffect();
        }
    }
}