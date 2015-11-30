using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIUtility : MonoBehaviour
{
	//Adds GameObject -> UI -> Dropdown menu item that instantiates
	//a new button and attaches a dropdown component.
	[MenuItem("GameObject/UI/Dropdown")]
	public static void NewDropdown()
	{
		// NOTE -- Unity has implemented its own Dropdown so I changed the name from "Dropdown" to "Simple Dropdown"
		//NewButton("Dropdown", "Dropdown", GetCanvas().transform).gameObject.AddComponent<Dropdown>();
		NewButton("Simple Dropdown", "Simple Dropdown", GetCanvas().transform).gameObject.AddComponent<Dropdown>();
	}
	
	//If unable to find a canvas in the scene, creates a new one.
	//Also creates an event system if one is not found.
	public static Canvas GetCanvas()
	{
		Canvas c = FindObjectOfType<Canvas>();
		if (c == null)
		{
			c = new GameObject().AddComponent<Canvas>();
			c.name = "Canvas";
			c.gameObject.layer = 5;
			c.renderMode = RenderMode.ScreenSpaceOverlay;
			c.gameObject.AddComponent<CanvasScaler>();
			c.gameObject.AddComponent<GraphicRaycaster>();
		}
		if (FindObjectOfType<EventSystem>() == null)
		{
			EventSystem e = new GameObject().AddComponent<EventSystem>();
			e.name = "Event System";
			e.gameObject.AddComponent<StandaloneInputModule>();
			e.gameObject.AddComponent<TouchInputModule>();
		}
		return c;
	}
	
	//Creates & initializes an empty recttransform inside the given parent.
	public static RectTransform NewUIElement(string name, Transform parent)
	{
		RectTransform temp = new GameObject().AddComponent<RectTransform>();
		temp.name = name;
		temp.gameObject.layer = 5;
		temp.SetParent(parent);
		temp.localScale = new Vector3(1, 1, 1);
		temp.localPosition = new Vector3(0, 0, 0);
		return temp;
	}
	
	//Creates & initializes a new text element inside the given parent.
	public static Text NewText(string text, Transform parent)
	{
		RectTransform textRect = NewUIElement("Text", parent);
		Text t = textRect.gameObject.AddComponent<Text>();
		t.text = text;
		t.color = Color.black;
		t.alignment = TextAnchor.MiddleCenter;
		ScaleRect(textRect, 0, 0);
		textRect.anchorMin = new Vector2(0, 0);
		textRect.anchorMax = new Vector2(1, 1);
		return t;
	}
	
	//Creates & initializes a button(with a text child) inside of the given parent.
	public static Button NewButton(string name, string text, Transform parent)
	{
		RectTransform btnRect = NewUIElement(name, parent);
		btnRect.gameObject.AddComponent<Image>();
		btnRect.gameObject.AddComponent<Button>();
		ScaleRect(btnRect, 160, 30);
		NewText(text, btnRect);
		
		return btnRect.GetComponent<Button>();
	} 
	
	//Sets width and height with current anchors
	public static void ScaleRect(RectTransform r, float w, float h)
	{
		//Setting size along horizontal axis (width)
		r.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, w);
		
		//Setting size along vertical axis (height)
		r.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, h);
	}
}