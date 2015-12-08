using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class timer_display : MonoBehaviour {

	public static Text timer;
	//private int Money = 0;
	void Awake()
	{
		timer  = GetComponent<Text>();
		//txt.text = "hi";
	}
	void Start (){
		//GameObject.Find("CountText").GetComponent<Text>();
		//txt  = GameObject.Find ("money display/Text").GetComponent<Text>;
		//txt.text = "hi";
		//txt  = transform.Find ("money display/Text").GetComponent<Text>();
		//txt.text = "hi";
	}

	void Update() {
        //Money += 100;

        var minutes = world.timeLeft / 60;
        var seconds = world.timeLeft % 60;

        timer.text= string.Format("{0:0}:{1:00}", minutes, seconds);
    }

}
