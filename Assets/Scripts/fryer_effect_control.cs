using UnityEngine;
using System.Collections;

public class fryer_effect_control : MonoBehaviour {

    public AudioSource fryerAudioSource;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake()
    {
        fryerAudioSource.volume = GameManager.effectVolume;
    }
}
