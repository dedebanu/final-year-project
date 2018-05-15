using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Rigidbody rigidbody;
	Vector3 velocity;
	Vector3 rotation;
	Vector3 jump;

	float h;
	float v;
	float yrotate;
	public float walkspeed=10f;
	public float runspeed=20f;
	public float rotationspeed=20f;
	public float jumpforce=50f;
	
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		jump=new Vector3(0f,jumpforce,0f);
	}

	void Update () {
		h= Input.GetAxis("Horizontal");//left right
		v=Input.GetAxis("Vertical") ;//up down
		yrotate=Input.GetAxis("Mouse X")*rotationspeed;
		
		velocity=new Vector3(v,0f,-h);
		rotation=new Vector3(0f,yrotate,0f);

		 if (Input.GetAxis("Fire1")>.01){
			 transform.Translate(velocity * Time.deltaTime*runspeed,Space.Self);
			 Debug.Log("running");
		 }
		 else
		 {
		transform.Translate(velocity * Time.deltaTime*walkspeed,Space.Self);
		Debug.Log("Walking");	 
		 }
		if (Input.GetButtonDown("Jump")){
			rigidbody.AddForce(jump, ForceMode.Impulse);
		}
		
		 transform.Rotate(rotation * Time.deltaTime, Space.Self);
	}

	
}
