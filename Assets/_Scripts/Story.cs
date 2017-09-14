using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour {

	public GameObject description1;
	public GameObject description2;
	public GameObject description3;
	public GameObject description4;
	public GameObject description5;
	public GameObject newGame;
	public GameObject play;
	public GameObject quit;

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


	}
	
	// Update is called once per frame
	void Update () {

	}
		
}