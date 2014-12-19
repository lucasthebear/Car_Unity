using UnityEngine;
using System.Collections;

public class FaceFront : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.MoveRotation(Quaternion.LookRotation(rigidbody.velocity));
	}
}
