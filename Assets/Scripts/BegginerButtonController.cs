using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BegginerButtonController : MonoBehaviour {

	public void GameStart() {
		SceneManager.LoadScene ("Play");
	}

}