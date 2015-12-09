using UnityEngine;
using System.Collections;

public class shotglass : MonoBehaviour {
    private bool busy;
    public BarItem shotGlassFull;
    public world worldInfo;
    string otherPresent;
    bool pouring = false;
    float pourTime = 0f;
    float pourDelay = 0f;
    Collider2D otherCollider;
    private BarItem itemToMake;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!busy && Input.GetMouseButtonUp(0) && (otherPresent != null))
        {
            pourTime = pourDelay;
            pouring = true;
            busy = true;
            Destroy(otherCollider.gameObject);
        }

        pourTime -= Time.deltaTime;
        if (pourTime <= 0 && pouring)
        {
            otherPresent = null;
            pouring = false;
            busy = false;
            Instantiate(itemToMake);
        }
    }

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        switch (collider2d.tag)
        {
            case "Whiskey":
                otherPresent = collider2d.tag;
                otherCollider = collider2d;
                itemToMake = shotGlassFull;
                break;
        }
    }

    void OnTriggerExit2D(Collider2D collider2d)
    {
        otherPresent = null;
        otherCollider = null;
    }
}
