using UnityEngine;
using System.Collections;

public class music_control : MonoBehaviour {

    public AudioSource musicBackgroundSource;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake () {
        musicBackgroundSource.volume = GameManager.musicVolume;
    }
}
