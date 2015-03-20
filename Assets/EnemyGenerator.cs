using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {

	private float currentTime;
	// Use this for initialization
	void Start () {
		currentTime = 0.0f;
		
		generateEnemy();
	}
	
	// Update is called once per frame
	void Update () {
	
		currentTime += Time.deltaTime;
		
		int timeRounded = (int)currentTime;
		if(timeRounded%10==0)
		{
			//generateEnemy();
			Debug.Log("enemy generated");
		}
	}
	void generateEnemy()
	{
		GameObject enemy = (GameObject)Instantiate(GameObject.Find ("Enemy"),Vector3.zero,Quaternion.identity);
	}
}
