using UnityEngine;
using System.Collections;

public class MissileBehaviour : MonoBehaviour {

	public Vector3 startPos;
	public Vector3 targetPos;
	public GUIText mstatus;
	private float missileLifeTime;
	private float journeyLength;
	private float speed = 50.0f;
	private float startTime = 0.0f;
	// Use this for initialization
	void Start () 
	{
		missileLifeTime =0.0f;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
			startTime += Time.deltaTime	;	
			float distCovered = startTime * speed;
			journeyLength = Vector3.Distance(startPos,targetPos);
			float fracJourney = distCovered/journeyLength;
			transform.position = Vector3.Lerp(startPos,targetPos,fracJourney);
			
			if(missileLifeTime > 10.0f)
			{
								
				DestroyObject(this.gameObject);
				missileLifeTime = 0.0f;
				
			}
		
	
	}
}
