using UnityEngine;
using System.Collections;

public class beerTap : MonoBehaviour {

    Animator animator;

    bool glassPresent = false;
    bool pouring = false;
    float pourTime = 0;
    float pourDelay = 1.5f;
    bool leftMouseButton;
    Collider2D glass;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonUp(0) && glassPresent)
        {
            pourTime = pourDelay;
            pouring = true;
            animator.SetTrigger("tapON");
            Destroy(glass.gameObject);
        }
        
        pourTime -= Time.deltaTime;
        if (pourTime <= 0 && pouring)
        {
            animator.SetTrigger("tapOFF");
            glassPresent = false;
            pouring = false;
        }
        
	}

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d.tag == "BeerGlass")
        {
            glassPresent = true;
            glass = collider2d;
        }
    }

    void OnTriggerExit2D(Collider2D collider2d)
    {
        if (collider2d.tag == "BeerGlass")
        {
            glassPresent = false;
            glass = null;
        }
    }
}
