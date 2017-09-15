using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Instructions1 : MonoBehaviour {

	public GameObject background;
	public GameObject instructions;
	public GameObject play;

	public Button playButton;

	// Use this for initialization
	IEnumerator Start () {

		background.SetActive (false);
		instructions.SetActive (false);
		play.SetActive (false);

		yield return new WaitForSeconds (1);

		background.SetActive (true);
		instructions.SetActive (true);
		play.SetActive (true);

		playButton.onClick.AddListener (returnToGame);
	}

	void returnToGame() {
		background.SetActive (false);
		instructions.SetActive (false);
		play.SetActive (false);
	}


	// Update is called once per frame
	void Update () {

	}
}
