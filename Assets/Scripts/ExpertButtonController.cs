using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class ExpertButtonController : MonoBehaviour {

	public void GameStart() {
		SceneManager.LoadScene ("Play");
	}

}