using UnityEngine;
using System.Collections;

public class Stage : MonoBehaviour {
    GameObject star;
	// Use this for initialization
	void Awake(){
        if (GameManager.level_1_star == 1)
        {
            star = transform.Find("level_1_star/1 star").gameObject;
            star.SetActive(true);
        }
        else if (GameManager.level_1_star == 2)
        {
            star = transform.Find("level_1_star/2 star").gameObject;
            star.SetActive(true);
        }
        else if (GameManager.level_1_star == 3)
        {
            star = transform.Find("level_1_star/3 star").gameObject;
            star.SetActive(true);
        }

        if (GameManager.level_2_star == 1)
        {
            star = transform.Find("level_2_star/1 star").gameObject;
            star.SetActive(true);
        }
        else if (GameManager.level_2_star == 2)
        {
            star = transform.Find("level_2_star/2 star").gameObject;
            star.SetActive(true);
        }
        else if (GameManager.level_2_star == 3)
        {
            star = transform.Find("level_2_star/3 star").gameObject;
            star.SetActive(true);
        }

        if (GameManager.level_3_star == 1)
        {
            star = transform.Find("level_3_star/1 star").gameObject;
            star.SetActive(true);
        }
        else if (GameManager.level_3_star == 2)
        {
            star = transform.Find("level_3_star/2 star").gameObject;
            star.SetActive(true);
        }
        else if (GameManager.level_3_star == 3)
        {
            star = transform.Find("level_3_star/3 star").gameObject;
            star.SetActive(true);
        }
    }
	
}
