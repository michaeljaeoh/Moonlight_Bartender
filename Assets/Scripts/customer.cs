using UnityEngine;
using System.Collections;

public class customer : MonoBehaviour {
    private bool done, sitting;
    public seat seat1;

	// Use this for initialization
	void Start () {
        done = false;
        sitting = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (!done) {
            if (!sitting) {
                if (!seat1.getBusy()) {
                    seat1.setBusy();

                }
            }
        }

	}
}
