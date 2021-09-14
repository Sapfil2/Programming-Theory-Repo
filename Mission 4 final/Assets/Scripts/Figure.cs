using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Figure : MonoBehaviour
{
    protected int price;

    public int getPrice() 
    {
        return price;
    }

    protected void setPrice(int price)
    {
        this.price = price;
    }

    private void OnMouseDown()
    {
        LogTouch();
        HandleTouch();
    }

    public abstract void LogTouch();
    public abstract void HandleTouch();
}
