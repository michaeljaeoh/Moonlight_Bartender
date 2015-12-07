using UnityEngine;
using System.Collections;

public class shop_category : MonoBehaviour {

	public void ChangeCategory(string name)
	{
		if (name == "equiment") {
			GameObject fryer = transform.Find ("upgrade fryer").gameObject;
			fryer.SetActive (true);
			
			GameObject beertap = transform.Find ("upgrade beertap").gameObject;
			beertap.SetActive (true);
			
			GameObject shaker = transform.Find ("upgrade shaker").gameObject;
			shaker.SetActive (true);

			GameObject chicken= transform.Find ("chicken wings").gameObject;
			chicken.SetActive (false);
			
			GameObject fries = transform.Find ("fries").gameObject;
			fries.SetActive (false);
			
			GameObject olive = transform.Find ("olive").gameObject;
			olive.SetActive (false);

			GameObject mojito = transform.Find ("mojito").gameObject;
			mojito.SetActive (false);
			
			GameObject martini = transform.Find ("martini").gameObject;
			martini.SetActive (false);
			





		} 
		else if (name == "food") {
			GameObject fryer = transform.Find ("upgrade fryer").gameObject;
			fryer.SetActive (false);
			
			GameObject beertap = transform.Find ("upgrade beertap").gameObject;
			beertap.SetActive (false);
			
			GameObject shaker = transform.Find ("upgrade shaker").gameObject;
			shaker.SetActive (false);
			
			GameObject chicken= transform.Find ("chicken wings").gameObject;
			chicken.SetActive (true);
			
			GameObject fries = transform.Find ("fries").gameObject;
			fries.SetActive (true);
			
			GameObject olive = transform.Find ("olive").gameObject;
			olive.SetActive (true);
			
			GameObject mojito = transform.Find ("mojito").gameObject;
			mojito.SetActive (false);
			
			GameObject martini = transform.Find ("martini").gameObject;
			martini.SetActive (false);

		}
		else if (name == "recipe") {
			GameObject fryer = transform.Find ("upgrade fryer").gameObject;
			fryer.SetActive (false);
			
			GameObject beertap = transform.Find ("upgrade beertap").gameObject;
			beertap.SetActive (false);
			
			GameObject shaker = transform.Find ("upgrade shaker").gameObject;
			shaker.SetActive (false);
			
			GameObject chicken= transform.Find ("chicken wings").gameObject;
			chicken.SetActive (false);
			
			GameObject fries = transform.Find ("fries").gameObject;
			fries.SetActive (false);
			
			GameObject olive = transform.Find ("olive").gameObject;
			olive.SetActive (false);
			
			GameObject mojito = transform.Find ("mojito").gameObject;
			mojito.SetActive (true);
			
			GameObject martini = transform.Find ("martini").gameObject;
			martini.SetActive (true);
		}
	}

}
