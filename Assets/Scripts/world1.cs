using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class world1 : world {
    // Use this for initialization
    void Start () {
        isLevel1 = true;
        star1 = 10;
        star2 = 20;
        star3 = 30;
        drinkOptions.Add("BeerGlassFull");
        drinkOptions.Add("shotGlassFull");

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
