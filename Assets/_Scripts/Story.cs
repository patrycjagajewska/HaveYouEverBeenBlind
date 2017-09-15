using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Story : MonoBehaviour {

	public GameObject[] descriptions;
	public GameObject newGame;
	public GameObject play;
	public GameObject quit;

	public Button playButton;
	public Button quitButton;

	public const string LEVEL_1 = "level1";

	// Use this for initialization
	IEnumerator Start () {

        foreach (GameObject description in descriptions)
        {
            description.SetActive(false);
        }

		newGame.SetActive (false);
		play.SetActive (false);
		quit.SetActive (false);
        
        yield return new WaitForSeconds(2);

        foreach (GameObject description in descriptions) {
            description.SetActive(true);
            yield return new WaitForSeconds(7);
            description.SetActive(false);
        }
       
		newGame.SetActive(true);

		yield return new WaitForSeconds (2);
		play.SetActive(true);
		quit.SetActive(true);

		playButton.GetComponent<Button>().onClick.AddListener (LoadLevel1);
		quitButton.GetComponent<Button>().onClick.AddListener (quitGame);

	}

	public static void LoadLevel1()
    {
        Debug.Log("You have clicked the button!");
        SceneManager.LoadScene(LEVEL_1);
	}
		
	void quitGame() {
		Application.Quit ();
	}

		
}