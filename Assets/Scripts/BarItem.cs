using UnityEngine;
using System.Collections;

public class BarItem : MonoBehaviour {
    private bool mouseOver;
    private bool active;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0) && mouseOver)
            active = true;
        if (!Input.GetMouseButton(0))
            active = false;
        if (active) {
            var mousePos = Input.mousePosition;
            var wantedPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10));
            transform.position = wantedPos;
        }

	}

    void OnMouseEnter() {
        mouseOver = true;
    }

    void OnMouseExit() {
        mouseOver = false;
    }

    void OnTriggerEnter2D(Collider2D collider2d) {
    }
    
}
