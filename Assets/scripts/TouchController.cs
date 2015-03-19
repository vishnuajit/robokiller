using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

public GUIText status;
public GameObject missile;
public GameObject plane;
public Transform testTransform;
public GameObject bomb;

private Rigidbody missileRB;
private GameObject sphere;
private Vector3 missileStartRot;
private float touchX;
private float touchY;
private Vector3 touchPos;
	// Use this for initialization
	void Start () 
	{
		status.text="init";
		
		missileStartRot = new Vector3(0.0f,90.0f,0.0f);
		touchPos = new Vector3();
		
	}
	
	// Update is called once per frame
	void firemissile(Vector3 targetPos)
	{
		Debug.Log("fire missile invoked");
		Ray ray = Camera.main.ScreenPointToRay(targetPos);
		RaycastHit hit;
		if(Physics.Raycast(ray,out hit))
		{
			
			status.text = "clicked sky at"+hit.point;
			GameObject sphere = (GameObject)Instantiate(bomb,plane.transform.position,Quaternion.identity);
			sphere.GetComponent<MissileBehaviour>().startPos = plane.transform.position;
			sphere.GetComponent<MissileBehaviour>().targetPos = hit.point;
				
		}
		
	}
	void Update () 
	{
		if(Input.GetMouseButtonUp(0))
		{
			
			touchX = Input.mousePosition.x;
			touchY = Input.mousePosition.y;
			touchPos = new Vector3(touchX,touchY,0.0f);
			firemissile(touchPos);
		}
		
		if(Input.touchCount>0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase==TouchPhase.Began)
			{
				touchX = touch.position.x;
				touchY = touch.position.y;
				touchPos = new Vector3(touchX,touchY,0.0f);
				firemissile(touchPos);
			}
			
		}
		else
		{
			
			status.text="touch lifted";
			
		}
		
	}
	
}
