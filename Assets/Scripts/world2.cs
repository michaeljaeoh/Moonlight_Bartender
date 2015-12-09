using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class world2 : world
{
    // Use this for initialization
    void Start()
    {
        drinkOptions.Add("BeerGlassFull");
        drinkOptions.Add("shotGlassFull");

        foodOptions.Add("FriesPlated");
        foodOptions.Add("ChickenWingsPlated");

        customer_stack.Push(chia);
        customer_stack.Push(Customer);
        customer_stack.Push(Alcoholic);
        customer_stack.Push(Customer);
        customer_stack.Push(Customer);
        customer_stack.Push(chia);
        customer_stack.Push(Customer);
        customer_stack.Push(Customer);
        customer_stack.Push(Alcoholic);
        customer_stack.Push(Customer);
    }
}
