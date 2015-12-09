using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class world3 : world
{
    // Use this for initialization
    void Start()
    {
        isLevel3 = true;
        star1 = 80;
        star2 = 110;
        star3 = 130;
        drinkOptions.Add("BeerGlassFull");
        drinkOptions.Add("shotGlassFull");
        drinkOptions.Add("Martini");
        drinkOptions.Add("Mojito");

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
