using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetMove : MonoBehaviour {

	public Transform transform;
	Vector3 newPosition;
	void Start () {
		newPosition = transform.position;
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
			transform.position = newPosition;
		}
		print ("pointer clicked");
	}
		

}
