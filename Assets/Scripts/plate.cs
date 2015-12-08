using UnityEngine;
using System.Collections;

public class plate : MonoBehaviour {
    private bool busy;
    public BarItem fries;
    public BarItem chicken;
    public world worldInfo;
    string otherPresent;
    bool plating = false;
    float plateTime = 0;
    float plateDelay = 0f;
    Collider2D otherCollider;
    private BarItem itemToPlate;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!busy && Input.GetMouseButtonUp(0) && (otherPresent != null))
        {
            plateTime = plateDelay;
            plating = true;
            busy = true;
            Destroy(otherCollider.gameObject);
        }

        plateTime -= Time.deltaTime;
        if (plateTime <= 0 && plating)
        {
            otherPresent = null;
            plating = false;
            busy = false;
            Instantiate(itemToPlate);
        }
    }

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        switch (collider2d.tag)
        {
            case "FriesCooked":
                otherPresent = collider2d.tag;
                otherCollider = collider2d;
                itemToPlate = fries;
                break;
            case "ChickenWingsCooked":
                otherPresent = collider2d.tag;
                otherCollider = collider2d;
                itemToPlate = chicken;
                break;
        }
    }

    void OnTriggerExit2D(Collider2D collider2d)
    {
        if (collider2d.tag == "FriesUncooked")
        {
            otherPresent = null;
            otherCollider = null;
        }
    }
}
