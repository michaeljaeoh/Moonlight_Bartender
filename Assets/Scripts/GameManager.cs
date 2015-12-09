using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour {
    
    public static int money = 0;
    public static int level_1_star = 0;
    public static int level_2_star = 0;
    public static int level_3_star = 0;
    public static Dictionary<string, int> prices;
    public static Dictionary<string, float> delayTimes;

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
        prices.Add("shotGlassFull", 5);
        prices.Add("FriesPlated", 4);
        prices.Add("Martini", 10);
        prices.Add("ChickenWingsPlated", 8);
        prices.Add("Mojito", 9);
        prices.Add("everything else", 50);


        delayTimes = new Dictionary<string, float>();
        delayTimes.Add("beerTap", 2f);
        delayTimes.Add("fryer", 3f);
        delayTimes.Add("shaker", 3.5f);
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
    public void exitfun()
    {
        Application.Quit();
    }

    public void upgradeFryer()
    {
        if (money >= 200)
        {
            money -= 200;
            delayTimes["fryer"] -= 0.25f;
            print(delayTimes["fryer"]);
        }
    }

    public void upgradeShaker()
    {
        if (money >= 200)
        {
            money -= 200;

            delayTimes["shaker"] -= 0.25f;
            print(delayTimes["shaker"]);
        }

    }
    public void upgradeTap()
    {
        if (money >= 200)
        {
            money -= 200;
            delayTimes["beerTap"] -= 0.25f;
            print(delayTimes["beerTap"]);
        }
    }

    public void upgradeFries()
    {
        if (money >= 100)
        {
            money -= 100;
            prices["FriesPlayed"] += 1;
            print(prices["FriesPlayed"]);
        }
    }

    public void upgradeWings()
    {
        if (money >= 100)
        {
            money -= 100;
            prices["ChickenWingsPlated"] += 1;
            print(prices["ChickenWingsPlated"]);
        }
    }

    public void upgradeMartini()
    {
        if (money >= 100)
        {
            money -= 100;
            prices["Martini"] += 1;
            print(prices["Martini"]);
        }
    }

    public void upgradeMojito()
    {
        if (money >= 100)
        {
            money -= 100;
            prices["Mojito"] += 1;
            print(prices["Mojito"]);
        }
    }

    public void upgradeShot()
    {
        if (money >= 100)
        {
            money -= 100;
            prices["shotGlassFull"] += 1;
            print(prices["shotGlassFull"]);
        }
    }
}
