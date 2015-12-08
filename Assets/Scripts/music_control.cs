using UnityEngine;
using System.Collections;

public class music_control : MonoBehaviour {

    public AudioSource musicBackgroundSource;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (GameManager.paused) {
            musicBackgroundSource.Pause();
        }
        else {
            musicBackgroundSource.UnPause();
        }
	}

    void Awake () {
        musicBackgroundSource.volume = GameManager.musicVolume;
    }

}
