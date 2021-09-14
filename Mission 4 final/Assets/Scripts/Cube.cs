using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Figure
{
    public AudioSource audio;

    public override void HandleTouch()
    {
        audio.Play();
    }

    public override void LogTouch()
    {
        Debug.Log("Cube toched");
    }
}
