using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class customer : MonoBehaviour {
    private bool sitting, ordered, giveOrder, foundSeat, paid;
    private int count, total;
    public List<string> orderOptions, myOrder;
    public seat seat1;
    Collider2D item;
//    GameObject gameManager;


	// Use this for initialization
	void Start () {
//        gameManager = GameObject.Find("GameManager");

        myOrder = new List<string>();
        orderOptions = new List<string>();
        sitting = false;
        ordered = false;
        giveOrder = false; // what is this for?
        count = 0;
        total = 0;
        foundSeat = false;
        paid = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!sitting)
        {
			print (UIControl.checkDropdown);
            findSeat();
        }
        else if (!ordered)
        {
            placeOrder();
//            foreach (var item in myOrder) { total += gameManager.prices[item];}
        }
        else if (giveOrder && Input.GetMouseButtonUp(0))
        {
            count++;
            print("giveorder tag: " + item.tag);
            myOrder.Remove(item.tag);
            print("myorder count: " + myOrder.Count);
            Destroy(item.gameObject);
            giveOrder = false; // check this
        }
        else if (count == myOrder.Count)
        {
/*            if (!paid)
            {
                 gameManager.money += total;
                paid = true;
            }
 * */
            leaveSeat();
        }
	}

    void leaveSeat()
    {
        if (transform.position.x > -10.95F)
        {
            transform.Translate(Vector2.left * 5.0F * Time.deltaTime);
        }
        else 
        {
            print("I paid some monies in the amount"+total);
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
        else { sitting = true; }
    }

    void placeOrder()
    {
        //foreach (string thing in orderOptions)
        //    print("OrderOptions: " + thing);

        for (int i = 0; i < Random.Range(1, 3); ++i)
            myOrder.Add(orderOptions[Random.Range(0, orderOptions.Count)]);

        ordered = true;

        foreach (string thing in myOrder)
            print("myorder has: " + thing);
    }

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d.tag == "Seat")
        {
            seat1 = collider2d.gameObject.GetComponent<seat>();
            if (!seat1.getBusy())
            {
                foundSeat = true;
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
        if (collider2d.tag == "Seat")
        {
            seat1.clearBusy();
        }
        if (collider2d.tag == "BeerGlassFull") //check this
        {
            item = null;
            giveOrder = false; //check this
        }
    }

}
