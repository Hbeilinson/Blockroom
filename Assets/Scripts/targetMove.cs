using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetMove : MonoBehaviour {

	//public Rigidbody rigidbody;
	public Transform transform;
	Vector3 newPosition;
	public float speed;

	void Start () {
		newPosition = transform.position;
		//rigidbody = GetComponent<Rigidbody>();
	}
	void Update()
	{
		OnMouseOver ();
		if (Input.touchCount>0)
		{
			print ("touched");
			/*
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				newPosition = hit.point;
				transform.position = newPosition;
			}
			*/
		}
		if (Input.GetMouseButtonDown (0)) {
			//print ("clicked");

		}
	}
	void OnMouseOver() {
		if (Input.GetMouseButtonDown (0)) {
			//print ("clicked on a box");

		}
	}

	public void OnPointerClick() {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit))
		{
			newPosition = hit.point;
			//transform.position = newPosition;
			float step = speed * Time.deltaTime;

			transform.position = Vector3.MoveTowards(transform.position, newPosition, step);
			//rigidbody.MovePosition(newPosition);


		}
		print ("pointer clicked");
	}

//	public void onCollisionStay(Collision collision) {
//		transform.position = collision.contacts[0].point;
//	}
		

}
