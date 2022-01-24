using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {
	public int playerNo, charNo;
	public SpriteRenderer spriteRenderer;
	public Sprite p1_sprite, p2_sprite;


	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
		if (playerNo == 0) {
			
			charNo = CharacterManagment.getP1Char ();
			SetCharacterSprite (charNo);
			}

		if (playerNo == 1) {
			charNo = CharacterManagment.getP2Char ();
			SetCharacterSprite (charNo);
		}
	}


	// Update is called once per frame
	void Update () {
		if(GetComponent<PlayerHealth>().IsDead())
        {
            Destroy(this.gameObject);
        }


	}
	void SetCharacterSprite(int charNo){
		switch (charNo) {
		case 1:
			gameObject.GetComponent<SpriteRenderer> ().sprite = p1_sprite;
			break;
		case 2:
			gameObject.GetComponent<SpriteRenderer> ().sprite = p2_sprite;
			break;
		}
	}
   
}
