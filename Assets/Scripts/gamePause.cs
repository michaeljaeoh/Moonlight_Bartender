using UnityEngine;
using System.Collections;

public class gamePause : MonoBehaviour {

	// Use this for initialization
	public void pauseGame()
    {
       GameObject dial = transform.Find("World/Canvas/pause dialogue").gameObject;

        dial.SetActive(true);
    }
}
