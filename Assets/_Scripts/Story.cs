using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Story : MonoBehaviour {

	public GameObject description1;
	public GameObject description2;
	public GameObject description3;
	public GameObject description4;
	public GameObject description5;
	public GameObject newGame;
	public GameObject play;
	public GameObject quit;

	public Button playButton;
	public Button quitButton;

	public const string LEVEL_1 = "level1";

	// Use this for initialization
	IEnumerator Start () {

		description1.SetActive (false);
		description2.SetActive (false);
		description3.SetActive (false);
		description4.SetActive (false);
		newGame.SetActive (false);
		play.SetActive (false);
		quit.SetActive (false);

		yield return new WaitForSeconds(2);
		description1.SetActive(true);

		yield return new WaitForSeconds(7);
		description1.SetActive(false);
		description2.SetActive(true);

		yield return new WaitForSeconds(10);
		description2.SetActive(false);
		description3.SetActive(true);

		yield return new WaitForSeconds(5);
		description3.SetActive(false);
		description4.SetActive(true);

		yield return new WaitForSeconds(10);
		description4.SetActive(false);
		description5.SetActive(true);

		yield return new WaitForSeconds(10);
		description5.SetActive(false);
		newGame.SetActive(true);

		yield return new WaitForSeconds (2);
		play.SetActive(true);
		quit.SetActive(true);

		playButton.onClick.AddListener (LoadLevel1);
		quitButton.onClick.AddListener (quitGame);

	}

	public static void LoadLevel1() {
		SceneManager.LoadScene(LEVEL_1);
	}
		
	void quitGame() {
		Application.Quit ();
	}
	
	// Update is called once per frame
	void Update () {

	}
		
}