using UnityEngine;
using System.Collections;

public class BarSpawner : MonoBehaviour {
    public bool busy = false;
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
        if (!busy && !worldInfo.getMouseBusy() && Input.GetMouseButtonDown(0)) {
            worldInfo.setMouseBusy();
            busy = true;
            BarItem spawnedItem = Instantiate(barItem);
            spawnedItem.setSpawner(this);
        }
    }

    public void setBusyOff() {
        busy = false;
    }
}
