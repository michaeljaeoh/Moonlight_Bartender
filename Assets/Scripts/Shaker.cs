using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class Shaker : MonoBehaviour {

    private bool alcPresent, validItem;
    Collider2D mixItem;
    public BarItem martini;
    public BarItem mojito;

    //TRUNG SO TROLL GGGGGGGGGGGGG
    private bool busy, mixing;
    Animator animator;
    float mixTime = 0;
    float mixDelay = 3.5f;

    public List<string> added;

	// Use this for initialization
	void Start () {
	    added = new List<string>();
        animator = GetComponent<Animator>();
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
            if (added.Contains("Alcohol") && added.Contains("Olive"))
            {
                if (!busy)
                {
                    mixTime = mixDelay;
                    mixing = true;
                    animator.SetTrigger("mixON");
                    busy = true;
                }
                mixTime -= Time.deltaTime;
                if (mixTime <= 0 && mixing) 
                {
                    animator.SetTrigger("mixOFF");
                    Instantiate(martini);
                    validItem = false;
                    busy = false;
                    added.Clear();
                }  
            }
            else if (added.Contains("Alcohol") && added.Contains("Mint"))
            {
                if (!busy)
                {
                    mixTime = mixDelay;
                    mixing = true;
                    animator.SetTrigger("mixON");
                    busy = true;
                }
                mixTime -= Time.deltaTime;
                if (mixTime <= 0 && mixing)
                {
                    animator.SetTrigger("mixOFF");
                    Instantiate(mojito);
                    validItem = false;
                    busy = false;
                    added.Clear();
                }
            }
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
