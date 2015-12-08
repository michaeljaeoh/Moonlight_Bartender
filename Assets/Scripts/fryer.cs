using UnityEngine;
using System.Collections;

public class fryer : MonoBehaviour {
    Animator animator;
    private bool busy;

    public BarItem fries;
    public BarItem chicken;
    private BarItem itemToFry;
    public world worldInfo;

    string otherPresent;
    bool frying = false;
    float fryTime = 0;
    float fryDelay = 3f;
    Collider2D otherCollider;

    public AudioSource friesAudioSource;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!busy && Input.GetMouseButtonUp(0) && (otherPresent != null))
        {
            //&& !worldInfo.getMouseBusy()
            fryTime = fryDelay;
            frying = true;
            animator.SetTrigger("frying");
            //print("get in here!");
            //worldInfo.setMouseBusy();
            busy = true;

            friesAudioSource.Play();
            Destroy(otherCollider.gameObject);
        }

        fryTime -= Time.deltaTime;
        if (fryTime <= 0 && frying)
        {
            animator.SetTrigger("notFrying");
            otherPresent = null;
            frying = false;
            busy = false;
            //BarItem spawnedItem = 
            Instantiate(itemToFry);
            //spawnedItem.setSpawner(this);
        }
    }

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        switch (collider2d.tag)
        {
            case "FriesUncooked":
                otherPresent = collider2d.tag;
                otherCollider = collider2d;
                itemToFry = fries;
                break;
            case "ChickenWingsUncooked":
                otherPresent = collider2d.tag;
                otherCollider = collider2d;
                itemToFry = chicken;
                break;
        }
    }

    void OnTriggerExit2D(Collider2D collider2d)
    {
            otherPresent = null;
            otherCollider = null;
    }
}
