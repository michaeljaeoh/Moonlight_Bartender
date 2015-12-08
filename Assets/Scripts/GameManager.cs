using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour {
    
    public static int money = 0;
    public static int level_1_star = 0;
    public static int level_2_star = 0;
    public static int level_3_star = 0;
    public static Dictionary<string, int> prices;

    public static float musicVolume = 0.5f;
    public static float effectVolume = 0.5f;

    public static bool paused;

    void Start(){
        paused = false;
    }

    // Use this for initialization
    void Awake () {
        prices = new Dictionary<string, int>();
        prices.Add("BeerGlassFull", 6);
        prices.Add("FriesPlated", 4);
        prices.Add("Martini", 10);
        prices.Add("ChickenWingsPlated", 8);
        prices.Add("Mojito", 9);
        prices.Add("everything else", 50);
	}
	
	// Update is called once per frame
	void Update () {
        if (paused) {
            Time.timeScale = 0;
        }
        else {
            Time.timeScale = 1;
        }

    }

    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }


    public void OnApplicationPause()
    {
        paused = !paused;

    }
}
