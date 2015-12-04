using UnityEngine;
using System.Collections;

public class fryer : BarSpawner {
    Animator animator;
    bool otherPresent = false;
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
        if (!busy && !worldInfo.getMouseBusy() && Input.GetMouseButtonUp(0) && otherPresent)
        {
            fryTime = fryDelay;
            frying = true;
            animator.SetTrigger("frying");
            print("get in here!");
            worldInfo.setMouseBusy();
            busy = true;

            friesAudioSource.Play();
            Destroy(otherCollider.gameObject);
        }

        fryTime -= Time.deltaTime;
        if (fryTime <= 0 && frying)
        {
            animator.SetTrigger("notFrying");
            otherPresent = false;
            frying = false;
            BarItem spawnedItem = Instantiate(barItem);
            spawnedItem.setSpawner(this);
        }
    }

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d.tag == "FriesUncooked")
        {
            otherPresent = true;
            otherCollider = collider2d;
            //print("in trigger enter");
        }
    }

    void OnTriggerExit2D(Collider2D collider2d)
    {
        otherPresent = false;
        otherCollider = null;
    }
}
