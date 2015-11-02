using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class customer : MonoBehaviour {
    private bool done, sitting, ordered;
    private Dictionary<string, int> myOrder;
    private List<string> orderOptions;
    public seat seat1;




	// Use this for initialization
	void Start () {
        myOrder = new Dictionary<string, int>();
        orderOptions = new List<string>();
        orderOptions.Add("beer");
        done = false;
        sitting = false;
        ordered = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!sitting)
        {
            findSeat();
        }

        else if (!ordered)
        {
            placeOrder();
            foreach (var item in myOrder.Keys) { print(item); }
        }

        /*
	    if (!done) {
            if (!sitting) {
                if (!seat1.getBusy()) {
                    seat1.setBusy();
                    sitting = true;
                }
            }
        }
        */
	}

    void findSeat()
    {
        if (transform.position.x < seat1.transform.position.x)
        {
            transform.Translate(Vector2.right * Time.deltaTime);
        }
        else { sitting = true; }
    }

    void placeOrder()
    {
        float i = (float) orderOptions.Count - 1.0F;
        

        myOrder.Add(orderOptions[(int) Random.Range(0F, i)], 1);
        ordered = true;
    }

    void onTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d.tag == "Seat")
        {
            seat1.setBusy();
        }
    }

    void onTriggerExit2D(Collider2D collider2d)
    {
        if (collider2d.tag == "Seat")
        {
            seat1.clearBusy();
        }
    }

}
