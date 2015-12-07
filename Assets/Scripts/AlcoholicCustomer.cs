using UnityEngine;
using System.Collections;

public class AlcoholicCustomer : customer{

	// Use this for initialization
	void Start () {
        orderOptions.Add("BeerGlassFull");
        orderOptions.Add("Mojito");
        orderOptions.Add("Martini");
	}
	
	// Update is called once per frame
}
