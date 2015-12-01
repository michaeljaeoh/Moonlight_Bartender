using UnityEngine;
using System.Collections;

public class GameManager1 : MonoBehaviour {
    public static int musicCheckInGameManager;

    public void ChangeScene(string sceneName)
    {
        //hi++
        musicCheckInGameManager = UIControl.musicCheck;
        print("musicCheckInGameManager = " + musicCheckInGameManager);
        Application.LoadLevel(sceneName);
    }
}
