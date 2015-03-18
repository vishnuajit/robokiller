using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

public GUIText status;
public GameObject missile;
public GameObject plane;
public Transform testTransform;

private Rigidbody missileRB;
private GameObject sphere;

	// Use this for initialization
	void Start () 
	{
		status.text="init";
		 sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
	}
	
	// Update is called once per frame
	
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			status.text="clicked";
			GameObject missileClone =(GameObject) Instantiate(missile,testTransform.position,transform.rotation);
			Debug.DrawLine(missileClone.transform.position,plane.transform.position,Color.green,100.0f);
		}
		if(Input.touchCount>0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase==TouchPhase.Began)
			{
				status.text="\ntouched";
				Rigidbody missileClone =(Rigidbody) Instantiate(missile,testTransform.position,transform.rotation);
				//missileClone.velocity= Vector3.forward * 10;
				
			//	GameObject sphereClone = (GameObject) Instantiate(sphere,testTransform.position,transform.rotation);
			//	sphereClone.transform.Translate(Vector3.forward*30.0f);
				
				
				
			}
			
		}
		else
		{
			
		//	status.text="touch lifted";
			
		}
	}
	void FireMissile()
	{
	
	}
}
