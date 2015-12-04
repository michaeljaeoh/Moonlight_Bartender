using UnityEngine;
using System.Collections;

public class beerTap : MonoBehaviour {
    public BarItem barItem;
    Animator animator;
    private bool busy;
    bool glassPresent = false;
    bool pouring = false;
    float pourTime = 0;
    float pourDelay = 1.5f;
    bool leftMouseButton;
    Collider2D glass;

    public AudioSource beerAudioSource;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!busy && Input.GetMouseButtonUp(0) && glassPresent)
        {
            pourTime = pourDelay;
            pouring = true;
            animator.SetTrigger("tapON");
            busy = true;

            beerAudioSource.Play();
            Destroy(glass.gameObject);
        }
        
        pourTime -= Time.deltaTime;
        if (pourTime <= 0 && pouring)
        {
            animator.SetTrigger("tapOFF");
            glassPresent = false;
            pouring = false;
            BarItem spawnedItem = Instantiate(barItem);
            spawnedItem.setSpawner(this);
        }
        
	}

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d.tag == "BeerGlassEmpty")
        {
            glassPresent = true;
            glass = collider2d;
        }
    }
    
    void OnTriggerExit2D(Collider2D collider2d)
    {
        if (collider2d.tag == "BeerGlassEmpty")
        {
            glassPresent = false;
            glass = null;
        }
    }

    public void setBusyOff() {
        busy = false;
    }
}
