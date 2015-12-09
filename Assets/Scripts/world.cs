using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class world : MonoBehaviour {
    public bool mouseBusy, done;
    public NormalCustomer Customer;
    public AlcoholicCustomer Alcoholic;
    public Chia chia; 
    public int customer_count = 0;
    public Stack<customer> customer_stack;
    public List<string> drinkOptions, foodOptions;
    public static float timeLeft;
    public static int moneyEarned = 0;
    GameObject time;

    void Awake()
    {
        timeLeft = 120.0f;
        time = transform.Find("Canvas/end dialogue").gameObject;
        time.SetActive(false);
        Physics.queriesHitTriggers = true;
        customer_stack = new Stack<customer>();
        drinkOptions = new List<string>();
        foodOptions = new List<string>();
    }

    // Update is called once per frame
    void Update() {
        if (done)
        {
            timeLeft = 0;
            time.SetActive(true);
        }
        if (timeLeft > 0)
            timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            done = true;
           // GameObject time = transform.Find("Canvas/end dialogue").gameObject;            
        }


        if (Input.GetMouseButton(0)) {
            mouseBusy = false;
            //print(mouseBusy);
        }

        if (!done && customer_count < 3 && customer_stack.Count != 0)
        {
            customer newCustomer = customer_stack.Pop();
            Instantiate(newCustomer);
            newCustomer.staticWorldSetupMethod(this);
        }

        if (customer_stack.Count == 0 && customer_count == 0)
            done = true;
    }

    public bool getMouseBusy() {
        //print(mouseBusy);
        return mouseBusy;
    }

    public void setMouseBusy() {
        //print("Mouse busy");
        mouseBusy = true;
    }
}
