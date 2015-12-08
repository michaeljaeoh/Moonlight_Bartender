using UnityEngine;
using System.Collections;

public class beertap_effect_control : MonoBehaviour {

    public AudioSource beertapAudioSource;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.paused)
        {
            beertapAudioSource.Pause();
        }
        else
        {
            beertapAudioSource.UnPause();
        }
    }

    void Awake()
    {
        beertapAudioSource.volume = GameManager.effectVolume;
    }
}
