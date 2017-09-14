using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSun : MonoBehaviour {
	public GameObject directionalSun;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		directionalSun.transform.Rotate (0, 0.1f, 0);
	}
}
