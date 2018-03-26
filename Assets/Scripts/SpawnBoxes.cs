using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoxes : MonoBehaviour {

	public Vector3 center;
	public Vector3 size;


	public GameObject Boxprefab;
	public Transform player; 

	// Use this for initialization
	void Start () {

		float rand = Random.Range (40, 90);
		for (int i = 0; i < rand; i++) {
			SpawnBox ();
		}
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Q)) {
			SpawnBox ();
		}
		
	}

	public void SpawnBox()
	{
		Vector3 pos = center + new Vector3 (Random.Range(-size.x/2, size.x/2), Random.Range(-size.y/2, size.y/2), Random.Range(-size.z/2, size.z/2));
		if (Vector3.Distance(pos, player.position) > 7) {
			Instantiate (Boxprefab, pos, Quaternion.identity);
		}

	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = new Color (1, 0, 0, 0.5f);
		Gizmos.DrawCube (center, size);
	}


}
