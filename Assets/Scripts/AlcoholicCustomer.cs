using UnityEngine;
using System.Collections;

public class AlcoholicCustomer : customer{

	// Use this for initialization
	void Start () {
        orderOptions.AddRange(World.drinkOptions);
	}
	
	// Update is called once per frame
}
