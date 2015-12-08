using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class money : MonoBehaviour {

	public static Text txt;
	private int Money = 0;
	void Awake()
	{
		txt  = GetComponent<Text>();
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
		Money += 100;
		txt.text = "$ " + Money.ToString();
	}

}
