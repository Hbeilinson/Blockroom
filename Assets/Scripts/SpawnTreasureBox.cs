﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTreasureBox : MonoBehaviour {

	public Vector3 center;
	public Vector3 size;


	public GameObject Boxprefab;

	// Use this for initialization
	void Start () {
			SpawnBox ();
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
		//if ((pos.x - 20) > 5 && (pos.y - 23) > 5 && (pos.z - 20) > 5 && (20 - pos.x) > 5 && (23- pos.y) >5 && (20 - pos.z) > 5) {
		Instantiate (Boxprefab, pos, Quaternion.identity);
		//}
	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = new Color (1, 0, 0, 0.5f);
		Gizmos.DrawCube (center, size);
	}


}
