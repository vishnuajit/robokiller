using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {


	private GameObject plane;
	private float startTime =0.0f;
	private float journeyLength;
	private float speed = 5.0f;
	private Vector3 startPos;
	// Use this for initialization
	void Start () {
		plane = GameObject.Find("f16a");
		startPos = transform.position;
		
		
		float enemyX = Random.Range(-60.0f,15.0f);
		float enemyY = 25.0f;
		float enemyZ = 15.0f;
		Vector3 enemyStartPos = new Vector3(enemyX,enemyY,enemyZ);
		
		startPos = enemyStartPos;
	}
	
	// Update is called once per frame
	void Update () {
	
		startTime += Time.deltaTime	;	
		float distCovered = startTime * speed;
		journeyLength = Vector3.Distance(transform.position,plane.transform.position);
		float fracJourney = distCovered/journeyLength;
		transform.position = Vector3.Lerp(startPos,plane.transform.position,fracJourney);
	
	}
}
