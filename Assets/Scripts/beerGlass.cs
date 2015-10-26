using UnityEngine;
using System.Collections;

public class beerGlass : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            var mousePos = Input.mousePosition;
            var wantedPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10));
            transform.position = wantedPos;
        }

	}

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        //if (collider2d.tag == "BeerTap")
        //{
            print("waddddddduppppp");
       //     Destroy(this.gameObject);
        //}
    }
    
}
