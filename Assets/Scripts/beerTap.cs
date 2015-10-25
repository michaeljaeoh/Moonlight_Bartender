using UnityEngine;
using System.Collections;

public class beerTap : MonoBehaviour {

    Animator animator;

    bool pouring = false;
    float pourTime = 0;
    float pourDelay = 1.5f;


	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0) && !pouring)
        {
            pourTime = pourDelay;
            pouring = true;
            animator.SetTrigger("tapON");
        }
        pourTime -= Time.deltaTime;
        if (pourTime <= 0 && pouring)
        {
            animator.SetTrigger("tapOFF");
            pouring = false;
        }

	}
}
