using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class world : MonoBehaviour {
    private bool mouseBusy = false;
    public NormalCustomer Customer;
    public AlcoholicCustomer Alcoholic;
    public Chia chia; 
    public int customer_count = 0;
    private Stack<customer> customer_stack;
    float timeLeft = 180.0f;
    public float moneyEarned = 0;


    // Use this for initialization
    void Start () {
        Physics.queriesHitTriggers = true;
        //mouseBusy = true;
        //print(mouseBusy);
        customer_stack = new Stack<customer>();
        customer_stack.Push(chia);
        customer_stack.Push(Customer);
        customer_stack.Push(Alcoholic);
        customer_stack.Push(Customer);
    }

    // Update is called once per frame
    void Update() {
        timeLeft -= Time.deltaTime;

        if (Input.GetMouseButton(0)) {
            mouseBusy = false;
            //print(mouseBusy);
        }

        if (customer_count < 3 && customer_stack.Count != 0)
        {
            customer newCustomer = customer_stack.Pop();
            Instantiate(newCustomer);
            newCustomer.staticWorldSetupMethod(this);
        }
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
