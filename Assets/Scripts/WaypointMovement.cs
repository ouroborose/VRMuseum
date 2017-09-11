﻿using UnityEngine;
using System.Collections;

public class WaypointMovement : MonoBehaviour {
	
	public GameObject player;
	public GameObject raycastIndicator;


	public float height = 2;
	public bool teleport = true;

	public float maxMoveDistance = 10;
	private bool moving = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Move(GameObject waypoint) {
		if (!teleport) {
			iTween.MoveTo (player, 
				iTween.Hash (
					"position", new Vector3 (waypoint.transform.position.x, waypoint.transform.position.y + height / 2, waypoint.transform.position.z), 
					"time", .2F, 
					"easetype", "linear"
				)
			);
		} else {
			player.transform.position = new Vector3 (waypoint.transform.position.x, 
                waypoint.transform.position.y + height / 2, 
                waypoint.transform.position.z);
		}
	}

	public void WaypointHighlight(GameObject waypoint){
		Debug.Log ("way point highlighted");
		waypoint.SetActive(true);
		waypoint.GetComponent<Renderer> ().enabled = true;
		if (raycastIndicator != null) {
			raycastIndicator.SetActive (false);
		}
	}

	public void WaypointDeHighlight(GameObject waypoint) {
		Debug.Log ("way point off");
		//waypoint.SetActive(false);
		waypoint.GetComponent<Renderer> ().enabled = false;
		if (raycastIndicator != null) {
			raycastIndicator.SetActive (true);
		}
	}

}
