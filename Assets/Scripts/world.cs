using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class world : MonoBehaviour {
    private bool mouseBusy = false;
    public NormalCustomer Customer;
    public Chia chia;
    public int customer_count = 0;
    private Stack<customer> customer_stack;

	// Use this for initialization
	void Start () {
        Physics.queriesHitTriggers = true;
        //mouseBusy = true;
        //print(mouseBusy);
        customer_stack = new Stack<customer>();
        customer_stack.Push(Customer);
        customer_stack.Push(chia);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(0)) {
            mouseBusy = false;
            //print(mouseBusy);
        }

        if (customer_count < 3 && customer_stack.Count != 0)
            Instantiate(customer_stack.Pop());
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
