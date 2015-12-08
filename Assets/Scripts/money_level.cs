using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class money_level : MonoBehaviour {

	public static Text money;
	//private int Money = 0;
	void Awake()
	{
		money  = GetComponent<Text>();
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
        //Money
        money.text = world.moneyEarned.ToString();
	}

}
