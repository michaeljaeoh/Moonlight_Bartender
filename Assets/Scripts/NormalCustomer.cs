using UnityEngine;
using System.Collections;

public class NormalCustomer : customer {

	// Use this for initialization
	void Start () 
    {
        orderOptions.AddRange(World.drinkOptions);

        orderOptions.AddRange(World.foodOptions);

        //animator.SetInteger("alternateSprite", UnityEngine.Random.Range(0, 2));
    }
}
