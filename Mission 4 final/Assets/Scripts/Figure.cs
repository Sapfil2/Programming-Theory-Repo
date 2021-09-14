using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Figure : MonoBehaviour
{
    private void OnMouseDown()
    {
        LogTouch();
        HandleTouch();
    }

    public abstract void LogTouch();
    public abstract void HandleTouch();
}
