using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class Shaker : BarSpawner {

    private bool alcPresent, validItem;
    Collider2D mixItem;
    public BarItem martini;
    public BarItem mojito;

    public List<string> added;

	// Use this for initialization
	void Start () {
	    added = new List<string>();
	}
	
	// Update is called once per frame
	void Update () {
        if (alcPresent && Input.GetMouseButtonUp(0) && (mixItem != null))
        {
            added.Add(mixItem.tag);
            Destroy(mixItem.gameObject);
        }
        else if (validItem && Input.GetMouseButtonUp(0) && (mixItem != null))
        {
            added.Add(mixItem.tag);
            Destroy(mixItem.gameObject);
        }
        else if (added.Count > 1)
        {
            createDrink();
        }
        
	}

    void createDrink()
    {
        if (added.Contains("Alcohol") && added.Contains("Olive"))
        {
            Instantiate(martini);
            validItem = false;
            added.Clear();
        }
        else if (added.Contains("Alcohol") && added.Contains("Mint"))
        {
            Instantiate(mojito);
            validItem = false;
            added.Clear();
        }
    }

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d.tag == "Alcohol")
        {
            mixItem = collider2d;
            alcPresent = true;
        }
        if (!validItem && (collider2d.tag == "Olive" || collider2d.tag == "Mint"))
        {
            mixItem = collider2d;
            validItem = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider2d)
    {
        if (collider2d.tag == "Alcohol")
        {
            mixItem = null;
            alcPresent = false;
        }
        if (collider2d.tag == "Olive" || collider2d.tag == "Mint")
        {
            mixItem = null;
            validItem = false;
        }
    }
}
