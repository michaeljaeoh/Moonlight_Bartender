using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIControl : MonoBehaviour {

	public Dropdown myDropdown;
	public static int checkDropdown=0;
	void Awake()
{
		if (checkDropdown == 0) {
			print ("Fucking Unity is stupid!");
			print ("myDropdown.optionscheckDropdown].text = " + myDropdown.options[checkDropdown].text);
			print ("checkDropdown = " + checkDropdown);
			//myDropdown.options[checkDropdown].text = Off;
			} 
		//else {
			//myDropdown.value = 1;
		//}
}

	public void ChangeScene(string sceneName)
	{
		print (checkDropdown);
		//hi++
		Application.LoadLevel (sceneName);
	}
	

}
