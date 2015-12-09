using UnityEngine;
using System.Collections;

public class Logo : MonoBehaviour {
    public float delay = 2f;
   
	
	// Update is called once per frame
	void Update () {
        delay -= Time.deltaTime;
        if (delay <= 0 || Input.GetMouseButtonDown(0))
            Application.LoadLevel("MainMenue");        
    }


}
