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
            Vector3 worldpos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
            worldpos.z = 0f;
            spawnedItem.transform.position = worldpos;
            spawnedItem.setSpawner(this);
        }
    }

    public void setBusyOff() {
        busy = false;
    }
}
