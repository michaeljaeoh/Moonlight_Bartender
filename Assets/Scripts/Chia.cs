using UnityEngine;
using System.Collections;

public class Chia : customer {

    // Use this for initialization
    void Start()
    {
        orderOptions.AddRange(World.drinkOptions);

        orderOptions.AddRange(World.foodOptions);
    }

}
