using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

	public int roseSceneIndex;

	public void SceneChange(){

		int currentScene = SceneManager.GetActiveScene ().buildIndex;
		int sceneCount = SceneManager.sceneCountInBuildSettings;

		SceneManager.LoadScene((currentScene+1) % sceneCount);
	}
}
