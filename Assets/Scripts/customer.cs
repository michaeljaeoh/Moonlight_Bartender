using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class customer : MonoBehaviour {
    private bool done, dropped, sitting, ordered;
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
        dropped = false;
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
        else if (sitting && done && dropped)
        {
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
            sitting = false;
         
            // Resetting because we only have 1 customer rightn ow
            done = false;
            dropped = false;

        }
    }

    void findSeat()
    {
        if (transform.position.x < seat1.transform.position.x)
        {
            transform.Translate(Vector2.right * 5.0F * Time.deltaTime);
        }
        else { sitting = true; }
    }

    void placeOrder()
    {
        float i = (float) orderOptions.Count - 1.0F;
        

        myOrder.Add(orderOptions[(int) Random.Range(0F, i)], 1);
        ordered = true;
    }

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d.tag == "Seat")
        {
            seat1.setBusy();
        }

    }

    void OnTriggerStay2D(Collider2D collider2d)
    {
        if (collider2d.tag == "BeerGlassFull" && Input.GetMouseButtonUp(0))
        {
            done = true;
            dropped = true;
            Destroy(collider2d.gameObject);
        }
    }
 

 
    void OnTriggerExit2D(Collider2D collider2d)
    {
        if (collider2d.tag == "Seat")
        {
            seat1.clearBusy();
        }

    }

}
