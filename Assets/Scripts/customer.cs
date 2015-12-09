using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class customer : MonoBehaviour {
    public bool sitting, ordered, giveOrder, foundSeat, leaving;
    public int total;
    public List<string> orderOptions, myOrder;
    public seat seat1;
    Collider2D item;
    public static world World;
    public dialogueOrder diagOrder;
    public dialogueOrder customerDO;

    public float waitTime = 0;
    public float waitDelay = 30f; //over written by unity, set in gui
    public bool timedOut, waiting;
    public Animator animator;
    
//    GameObject gameManager;


	// Use this for initialization
	void Start () {
        //        gameManager = GameObject.Find("GameManager");
        //World.customer_count++;
        animator = GetComponent<Animator>();
        myOrder = new List<string>();
        orderOptions = new List<string>();
        sitting = false;
        ordered = false;
        giveOrder = false; // what is this for?
        //count = 0;
        total = 0;
        foundSeat = false;
        //paid = false;
	}

    // Update is called once per frame
    void Update () {
        if (waiting)
        {
            waitTime -= Time.deltaTime;
            if (waitTime <= 0)
            {
                timedOut = true;
            }
            else if (waitTime <= (waitDelay / 3))
            {
                //animator.SetTrigger("angry");
            }
        }
        if (!sitting)
        {
			//print (UIControl.musicCheck);
            findSeat();
        }
        else if (!ordered)
        {
            placeOrder();
            waitTime = waitDelay;
            waiting = true;
            customerDO = Instantiate(diagOrder);
            customerDO.transform.position = new Vector3(transform.position.x + 1.5f, 3.7f, transform.position.z);
            customerDO.drawOrder(ref myOrder);
//            foreach (var item in myOrder) { total += gameManager.prices[item];}
        }
        else if (giveOrder && Input.GetMouseButtonUp(0))
        {
            //count++;

            if (myOrder.Contains(item.tag))
            {
                //print("giveorder tag: " + item.tag);
                myOrder.Remove(item.tag);
                waitTime += 5f;
                total += GameManager.prices[item.tag];
                world.moneyEarned += GameManager.prices[item.tag];
                //print("myorder count: " + myOrder.Count);
                Destroy(item.gameObject);
                customerDO.drawOrder(ref myOrder);
                giveOrder = false; // check this
            }
        }
        else if (World.done || 0 == myOrder.Count || timedOut)
        {
            if (!leaving) { leaving = true;
            if (customerDO != null)
            {
                Destroy(customerDO.gameObject);
            }
        }
/*            if (!paid)
            {
                 gameManager.money += total;
                paid = true;
            }
 * */
            leaveSeat();
        }
	}

    internal void staticWorldSetupMethod(world gameObject)
    {
        World = gameObject;
        World.customer_count++;
    }

    void leaveSeat()
    {
        if (transform.position.x > -10.95F)
        {
            transform.Translate(Vector2.left * 5.0F * Time.deltaTime);
        }
        else 
        {
            //World.moneyEarned += total;
            print("I paid some monies in the amount: $" + total);
            sitting = false;
            // Resetting because we only have 1 customer rightn ow
            ordered = false;
            Destroy(this.gameObject);
        }
    }

    void findSeat()
    {
        if (!sitting)
        {
            //print("finding a seat MUTHAFUCKKAAAAAA");
            transform.Translate(Vector2.right * 5.0F * Time.deltaTime);
            if (foundSeat)
                if (transform.position.x > seat1.transform.position.x)
                    sitting = true;
        }
        //else { sitting = true; }
    }

    void placeOrder()
    {
        //foreach (string thing in orderOptions)
        //    print("OrderOptions: " + thing);

        for (int i = 0; i < UnityEngine.Random.Range(1, 4); ++i)
            myOrder.Add(orderOptions[UnityEngine.Random.Range(0, orderOptions.Count)]);

        ordered = true;

        //foreach (string thing in myOrder)
            //print(tag + " myorder has: " + thing);
    }

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d.tag == "Seat" && !leaving)
        {
            seat1 = collider2d.gameObject.GetComponent<seat>();
            if (!seat1.getBusy())
            {
                foundSeat = true;
//                mySeatFlag = 1;
                //print("setting seat to busy");
                seat1.setBusy();
            }
        }

        if (myOrder.Contains(collider2d.tag))
        {
            item = collider2d;
            giveOrder = true;
        }
    }

 
    void OnTriggerExit2D(Collider2D collider2d)
    {
        if (collider2d.tag == "Seat" && leaving)
        {
                leaving = false;
                seat1.clearBusy();
//                seat1.clearBusy();
          
        }
        //if (collider2d.tag == "BeerGlassFull") //check this
        //{
            item = null;
            giveOrder = false; //check this
        //}
    }

    void OnDestroy()
    {
        World.customer_count--;
    }
}