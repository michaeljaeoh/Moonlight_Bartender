using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIControl : MonoBehaviour {

    public Slider musicSlider;
    public Slider effectSlider;


    void Awake()
    {

        musicSlider.value = GameManager.musicVolume;
        effectSlider.value = GameManager.effectVolume;

    }

    public void UpdateMusicVoume()
    {
        GameManager.musicVolume = musicSlider.value;
    }

    public void UpdateEffectVoume()
    {
        GameManager.effectVolume = effectSlider.value;
    }
}
