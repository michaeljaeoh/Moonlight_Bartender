using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class dialogueOrder : MonoBehaviour {
    private List<string> orderList;
    public DialogueOrderItem beer;
    public DialogueOrderItem fries;
    private DialogueOrderItem[] orders;

    // Use this for initialization
    void Start () {
        orderList = new List<string>();
        orders = new DialogueOrderItem[3];
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
        /*
        for (int i = 0; i < 3; ++i)
        {
            if (orders[i] != null)
                Destroy(orders[i].gameObject);
        }
        */
    }

    public void drawOrder()
    {
        destroyOrder();

        for (int i = 0; i < orderList.Count; ++i)
        {
            print("in dialogueOrder.draworder() = " + orderList[i]);
            switch(orderList[i])
            {
                case "BeerGlassFull":
                    print("BeerGlassFull");
                    orders[i] = beer;
                    Instantiate(orders[i]);
                    break;
                case "FriesCooked":
                    print("FriesCooked");
                    orders[i] = fries;
                    Instantiate(orders[i]);
                    break;
            }

            orders[i].transform.position = new Vector3(transform.position.x, transform.position.y + (i * 0.1f), transform.position.z);
        }
    }

    void OnDestroy()
    {
        destroyOrder();
    }
}
