using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public GameObject startUI;
	public GameObject raycastIndicator;
	public GameObject waypointGroup;
	public static bool tourBegun;

	// Use this for initialization
	void Start () {
		tourBegun = false;
		raycastIndicator.SetActive (false);
		waypointGroup.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toggleUIStart() {
		startUI.SetActive (false);
		raycastIndicator.SetActive (true);
		waypointGroup.SetActive (true);

		tourBegun = true;
	}

	public void toggleUIEnd() {
	}
}
