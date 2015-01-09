using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {

	public float speed;
	public float rotationSpeed;

	public string horizontalAxis = "Horizontal";
	public string verticalAxis = "Vertical";

	// Use this for initialization
	void Start () {
		rotationSpeed = 150f;
	}

	// Update is called once per frame
	void Update () {

		float horizontal = Input.GetAxis (horizontalAxis);
		float vertical = Input.GetAxis (verticalAxis);

		transform.RotateAround(transform.position,
		                       Vector3.up,
		                       horizontal * Time.deltaTime * rotationSpeed);

		
		Vector3 movement = vertical * transform.forward * speed;
		
		rigidbody.AddForce(movement);

	}
	void OnCollisionEnter(Collision other)
	{Destroy(this.gameObject);
	Application.LoadLevel ("scene2");
	
	}
}
