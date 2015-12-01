using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIControl : MonoBehaviour {

	public Dropdown myDropdown;
	public static int musicCheck;

    void Awake()
    {
        musicCheck = GameManager1.musicCheckInGameManager;

        if (myDropdown.value != musicCheck) {
			print("Fucking Unity is stupid!");
            
            //trying to change it
            myDropdown.value = musicCheck;
            print("myDropdown.value = " + myDropdown.value);
            print("myDropdown.options[checkDropdown].text = " + myDropdown.options[musicCheck].text);
        } 
		
    }

    public void UpdateMusicCheck()
    {
        musicCheck = myDropdown.value;
    }
	
}
