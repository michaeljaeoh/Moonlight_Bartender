﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour {
    public static GameManager instance = null;
    public int money = 0;
    public Dictionary<string, int> prices;

	// Use this for initialization
	void Awake () {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        prices = new Dictionary<string, int>();
        prices.Add("BeerGlassFull", 6);
        prices.Add("FriesCooked", 4);
        prices.Add("everything else", 50);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}