using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Figure
{
    public AudioSource audio;

    // POLYMORPHISM
    public override void HandleTouch()
    {
        audio.Play();
    }

    // POLYMORPHISM
    public override void LogTouch()
    {
        Debug.Log("Cube toched");
    }

    private void Awake()
    {
        // INHERITANCE
        setPrice(3);
    }
}
