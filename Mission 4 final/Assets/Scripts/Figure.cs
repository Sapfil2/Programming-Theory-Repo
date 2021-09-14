using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION
public abstract class Figure : MonoBehaviour
{
    // ENCAPSULATION
    protected int price;

    // ENCAPSULATION
    public int getPrice() 
    {
        return price;
    }

    // ENCAPSULATION
    protected void setPrice(int price)
    {
        this.price = price;
    }

    // POLYMORPHISM
    private void OnMouseDown()
    {
        LogTouch();
        HandleTouch();
    }

    // ABSTRACTION
    public abstract void LogTouch();
    // ABSTRACTION
    public abstract void HandleTouch();
}
