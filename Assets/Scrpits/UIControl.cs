using UnityEngine;
using System.Collections;

public class UIControl : MonoBehaviour {

	public void ChangeScene(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}
	

}
