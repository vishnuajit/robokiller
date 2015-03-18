using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {


	public GUIText status;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 moveVector = new Vector3(0,0,Input.acceleration.x);
		status.text=""+transform.position;
		transform.Translate(moveVector);
		Vector3 pos = new Vector3(transform.position.x,transform.position.y,Mathf.Clamp(transform.position.z,-7.5f,7.5f));
		transform.position = pos;
		
	}
}
