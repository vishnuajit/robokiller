using UnityEngine;
using System.Collections;

public class MissileBehaviour : MonoBehaviour {

	public Vector3 startPos;
	private float missileLifeTime;
	// Use this for initialization
	void Start () {
		missileLifeTime =0.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
	rigidbody.velocity = Vector3.right * -100.0f;
	missileLifeTime+=Time.deltaTime;
	if(missileLifeTime > 10.0f)
	{
		Destroy(transform.gameObject);
		Debug.Log("missile destroyed"+this.name);
	}
	
	}
}
