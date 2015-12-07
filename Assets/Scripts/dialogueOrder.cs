using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class dialogueOrder : MonoBehaviour {
    private List<string> orderList;
    public DialogueOrderItem beer;
    public DialogueOrderItem fries;
    private DialogueOrderItem order1;
    private DialogueOrderItem order2;
    private DialogueOrderItem order3;

    // Use this for initialization
    void Start () {
        orderList = new List<string>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    internal void setOrderList(List<string> input)
    {
        orderList = input;
    }

    private void destroyOrder()
    {
        if (order1 != null)
            Destroy(order1.gameObject);
        if (order2 != null)
            Destroy(order2.gameObject);
        if (order3 != null)
            Destroy(order3.gameObject);
    }

    public void drawOrder()
    {
        destroyOrder();

        for (int i = 0; i < orderList.Count; ++i)
        {
           // print("in dialogueOrder.draworder() = " + orderList[i]);
            switch(orderList[i])
            {
                case "BeerGlassFull":
                    //   print("BeerGlassFull");
                    if (i == 0)
                    {
                        order1 = Instantiate(beer);
                        order1.transform.position = new Vector3(transform.position.x, transform.position.y + (i * 0.25f), transform.position.z - 0.1f);
                    }
                    else if (i == 1)
                    {
                        order2 = Instantiate(beer);
                        order2.transform.position = new Vector3(transform.position.x, transform.position.y + (i * 0.25f), transform.position.z - 0.1f);
                    }
                    else if (i == 2)
                    {
                        order3 = Instantiate(beer);
                        order3.transform.position = new Vector3(transform.position.x, transform.position.y + (i * 0.25f), transform.position.z - 0.1f);
                    }
                    break;
                case "FriesCooked":
                    //  print("FriesCooked");
                    if (i == 0)
                    {
                        order1 = Instantiate(fries);
                        order1.transform.position = new Vector3(transform.position.x, transform.position.y + (i * 0.25f), transform.position.z - 0.1f);
                    }
                    else if (i == 1)
                    {
                        order2 = Instantiate(fries);
                        order2.transform.position = new Vector3(transform.position.x, transform.position.y + (i * 0.25f), transform.position.z - 0.1f);
                    }
                    else if (i == 2)
                    {
                        order3 = Instantiate(fries);
                        order3.transform.position = new Vector3(transform.position.x, transform.position.y + (i * 0.25f), transform.position.z - 0.1f);
                    }
                    break;
            }
        }
    }

    void OnDestroy()
    {
        destroyOrder();
    }
}
