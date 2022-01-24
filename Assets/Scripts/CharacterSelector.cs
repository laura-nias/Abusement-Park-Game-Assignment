using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour {
	public Image p1char1, p1char2, p2char1, p2char2;
	Image char1, char2;
	public Button p1_lockin,p2_lockin;

	bool p1LockedIn;
	// Use this for initialization
	void Start () {
		char1 = p1char1;
		char2 = p1char2;
		p1_lockin.interactable = true;
		p2_lockin.interactable = false;
	}

	// Update is called once per frame
	public void SelectedChar1() {
		Deselect ();
		char1.enabled = true;

	}
	public void SelectedChar2() {
		Deselect ();
		char2.enabled = true;
	}
	void Deselect()
	{
		char1.enabled = false;
		char2.enabled = false;
	}
	public void P1LockIn()
	{
		if (char1.enabled) {
			CharacterManagment.SetP1Char (1);
		} else {
			CharacterManagment.SetP1Char (2);
		}

		char1 = p2char1;
		char2 = p2char2;
		p1LockedIn = true;
		p1_lockin.interactable = false;
		p2_lockin.interactable = true;


	}
	public void P2LockIn()
	{
		if (char1.enabled) {
			CharacterManagment.SetP2Char (1);
		} else {
			CharacterManagment.SetP2Char (2);
		}
		if ((p1LockedIn)&&(CharacterManagment.getP1Char() != CharacterManagment.getP2Char())) {
			SceneManager.LoadScene ("game");
            Time.timeScale = 1;
        }
	}
}
