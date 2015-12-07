using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class dialogueOrder : MonoBehaviour {
    public DialogueOrderItem beer;
    public DialogueOrderItem fries;
    public DialogueOrderItem martini;
    public DialogueOrderItem mojito;
    private DialogueOrderItem order1;
    private DialogueOrderItem order2;
    private DialogueOrderItem order3;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
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

    public void drawOrder(ref List<string> orderList)
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
                        order1.transform.position = new Vector3(transform.position.x, 5.4f, transform.position.z - 0.1f);
                    }
                    else if (i == 1)
                    {
                        order2 = Instantiate(beer);
                        order2.transform.position = new Vector3(transform.position.x, 4.7f, transform.position.z - 0.1f);
                    }
                    else if (i == 2)
                    {
                        order3 = Instantiate(beer);
                        order3.transform.position = new Vector3(transform.position.x, 4, transform.position.z - 0.1f);
                    }
                    break;
                case "FriesCooked":
                    //  print("FriesCooked");
                    if (i == 0)
                    {
                        order1 = Instantiate(fries);
                        order1.transform.position = new Vector3(transform.position.x, 5.4f, transform.position.z - 0.1f);
                    }
                    else if (i == 1)
                    {
                        order2 = Instantiate(fries);
                        order2.transform.position = new Vector3(transform.position.x, 4.7f, transform.position.z - 0.1f);
                    }
                    else if (i == 2)
                    {
                        order3 = Instantiate(fries);
                        order3.transform.position = new Vector3(transform.position.x, 4, transform.position.z - 0.1f);
                    }
                    break;
                case "Martini":
                    //  print("FriesCooked");
                    if (i == 0)
                    {
                        order1 = Instantiate(martini);
                        order1.transform.position = new Vector3(transform.position.x, 5.4f, transform.position.z - 0.1f);
                    }
                    else if (i == 1)
                    {
                        order2 = Instantiate(martini);
                        order2.transform.position = new Vector3(transform.position.x, 4.7f, transform.position.z - 0.1f);
                    }
                    else if (i == 2)
                    {
                        order3 = Instantiate(martini);
                        order3.transform.position = new Vector3(transform.position.x, 4, transform.position.z - 0.1f);
                    }
                    break;
                case "Mojito":
                    //  print("FriesCooked");
                    if (i == 0)
                    {
                        order1 = Instantiate(mojito);
                        order1.transform.position = new Vector3(transform.position.x, 5.4f, transform.position.z - 0.1f);
                    }
                    else if (i == 1)
                    {
                        order2 = Instantiate(mojito);
                        order2.transform.position = new Vector3(transform.position.x, 4.7f, transform.position.z - 0.1f);
                    }
                    else if (i == 2)
                    {
                        order3 = Instantiate(mojito);
                        order3.transform.position = new Vector3(transform.position.x, 4, transform.position.z - 0.1f);
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
