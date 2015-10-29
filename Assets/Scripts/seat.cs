using UnityEngine;
using System.Collections;

public class seat : MonoBehaviour {
    private bool busy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider2d) {
        busy = true;
    }

    void OnTriggerExit2D(Collider2D collider2d) {
        busy = false;
    }

    public bool getBusy() {
        return busy;
    }

    public void setBusy() {
        busy = true;
    }

    public void clearBusy() {
        busy = false;
    }
}
