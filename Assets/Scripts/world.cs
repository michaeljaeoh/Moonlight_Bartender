using UnityEngine;
using System.Collections;

public class world : MonoBehaviour {
    private bool mouseBusy = false;

	// Use this for initialization
	void Start () {
        //mouseBusy = true;
        //print(mouseBusy);
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(0)) {
            mouseBusy = false;
            //print(mouseBusy);
        }
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
