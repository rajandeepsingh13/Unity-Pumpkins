using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private Transform pumkinPos;

	private float zDistance = 7f;
	private float yDistance = 4f;

	// Use this for initialization
	void Awake () {
		pumkinPos = GameObject.Find ("Pumpkin").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		temp.y = pumkinPos.position.y + yDistance;
		temp.z = pumkinPos.position.z + zDistance;
		transform.position = temp;
	}
}
