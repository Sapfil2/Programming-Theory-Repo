using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Figure
{
    // POLYMORPHISM
    public override void HandleTouch()
    {
        float newScaleX = Random.Range(0.5f, 2.0f);
        float newScaleY = Random.Range(0.5f, 2.0f);
        float newScaleZ = Random.Range(0.5f, 2.0f);
        transform.localScale = new Vector3(newScaleX, newScaleY, newScaleZ);
    }

    // POLYMORPHISM
    public override void LogTouch()
    {
        Debug.Log("Sphere toched");
    }

    private void Awake()
    {
        // INHERITANCE
        setPrice(4);
    }
}
