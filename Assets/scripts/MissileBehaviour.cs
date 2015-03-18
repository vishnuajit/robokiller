using UnityEngine;
using System.Collections;

public class MissileBehaviour : MonoBehaviour {

	public Vector3 startPos;
	public Vector3 targetPos;
	private float missileLifeTime;
	private float journeyLength;
	private float speed = 10.0f;
	// Use this for initialization
	void Start () 
	{
		missileLifeTime =0.0f;
		startPos = transform.position;
		journeyLength = Vector3.Distance(startPos,targetPos);
		
	}
	
	// Update is called once per frame
	void Update () 
	{
			missileLifeTime+=Time.deltaTime;
		
			Vector3 targetDirection = targetPos.normalized;
			Vector3  shootForce = new Vector3(targetDirection.x * -10,targetDirection.y * 10 , targetDirection.z * 10);
			//rigidbody.velocity = targetDirection * -200.0f;
			rigidbody.AddForce(shootForce);
			
			
			//float distCovered = (Time.time - missileLifeTime) * speed;
			//float fracJourney = distCovered/journeyLength;
		//	transform.position = Vector3.Lerp(startPos,targetPos,fracJourney);
			
			if(missileLifeTime > 10.0f)
			{
				Debug.Log("missile destroyed"+this.name);
				
				DestroyObject(this.gameObject);
				
			}
		
	
	}
}
