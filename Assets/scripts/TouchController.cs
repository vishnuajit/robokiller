using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

public GUIText status;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.touchCount>0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase==TouchPhase.Began)
			{
				status.text="\ntouched";
			}
			
		}
		else
		{
			
			status.text="touch lifted";
			
		}
	}
}
