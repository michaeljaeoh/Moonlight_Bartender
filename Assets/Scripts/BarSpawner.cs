using UnityEngine;
using System.Collections;

public class BarSpawner : MonoBehaviour {
    private bool mouseOver;
    public world worldInfo;
    public BarItem barItem;

	// Use this for initialization
	void Start () {
        //Physics.queriesHitTriggers = true;
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseOver() {
        if (!worldInfo.getMouseBusy() && Input.GetMouseButtonDown(0))
        {
            worldInfo.setMouseBusy();
            Instantiate(barItem);
        }
    }
}
