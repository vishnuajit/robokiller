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
private float touchX;
private float touchY;
private Vector3 touchPos;
	// Use this for initialization
	void Start () 
	{
		status.text="init";
		missileStartPos = new Vector3(-17.3f,0.0f,0.0f);
		missileStartRot = new Vector3(0.0f,90.0f,0.0f);
		touchPos = new Vector3();
		
	}
	
	// Update is called once per frame
	void firemissile()
	{
		Debug.Log("touchpos"+touchPos);
		//Vector3 worldPos = Camera.main.ScreenToWorldPoint(touchPos);
		status.text="clicked"+touchPos;
		Quaternion mrot = Quaternion.Euler(missileStartRot);
		Vector3 mpos = new Vector3(missileStartPos.x,missileStartPos.y,plane.transform.position.z);
		GameObject missileClone =(GameObject) Instantiate(missile,mpos,mrot);
		Vector3 missileTargetPos = new Vector3(touchX,touchY,0.0f);
		missileClone.GetComponent<MissileBehaviour>().targetPos = missileTargetPos;
		
	//	GameObject sphere = (GameObject)Instantiate(GameObject.CreatePrimitive(PrimitiveType.Sphere),worldPos,Quaternion.identity);
		//Vector3 spos = new Vector3(touchX,touchY,0);
		//sphere.transform.position = worldPos;
		
	}
	void Update () 
	{
		if(Input.GetMouseButtonUp(0))
		{
			
			touchX = Input.mousePosition.x;
			touchY = Input.mousePosition.y;
			touchPos = new Vector3(touchX,touchY,0.0f);
			firemissile();
		}
		/*
		if(Input.touchCount>0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase==TouchPhase.Began)
			{
				touchX = touch.position.x;
				touchY = touch.position.y;
				firemissile();
			}
			
		}
		else
		{
			
		//	status.text="touch lifted";
			
		}
		*/
	}
	
}
