﻿using UnityEngine;
using System.Collections;

public class NormalCustomer : customer {

	// Use this for initialization
	void Start () 
    {
        orderOptions.Add("BeerGlassFull");
        orderOptions.Add("FriesPlated");
        orderOptions.Add("ChickenWingsPlated");
	}
}
