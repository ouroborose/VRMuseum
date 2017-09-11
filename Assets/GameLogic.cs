using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public GameObject startUI;
	public GameObject raycastIndicator;
	public GameObject waypointGroup;
	public bool tourBegun = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toggleUIStart() {
		startUI.SetActive (false);
		tourBegun = true;
	}

	public void toggleUIEnd() {
	}
}
