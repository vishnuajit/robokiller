using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

public GUIText status;
public GameObject missile;
public GameObject plane;
public Transform testTransform;

private Rigidbody missileRB;
private GameObject sphere;
private Vector3 missileStartPos;
	private Vector3 missileStartRot;
	// Use this for initialization
	void Start () 
	{
		status.text="init";
		 sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		missileStartPos = new Vector3(-17.3f,0.0f,0.0f);
		missileStartRot = new Vector3(0.0f,90.0f,0.0f);
		
	}
	
	// Update is called once per frame
	void firemissile()
	{
		status.text="clicked";
		Quaternion mrot = Quaternion.Euler(missileStartRot);
		Vector3 mpos = new Vector3(missileStartPos.x,missileStartPos.y,plane.transform.position.z);
		GameObject missileClone =(GameObject) Instantiate(missile,mpos,mrot);
		
		
		
	}
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			
			firemissile();
			
		}
		if(Input.touchCount>0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase==TouchPhase.Began)
			{
				firemissile();
				
				
				
			}
			
		}
		else
		{
			
		//	status.text="touch lifted";
			
		}
	}
	
}
