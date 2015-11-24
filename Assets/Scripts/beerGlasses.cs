using UnityEngine;
using System.Collections;

public class beerGlasses : MonoBehaviour {
    private bool mouseOver;
    public world worldInfo;
    public beerGlass beerglass;

	// Use this for initialization
	void Start () {
        Physics.queriesHitTriggers = true;
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseOver() {
        if (!worldInfo.getMouseBusy() && Input.GetMouseButtonDown(0))
        {
            worldInfo.setMouseBusy();
            Instantiate(beerglass);
        }
    }
}
