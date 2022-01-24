using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerUI : MonoBehaviour {

	public Text p1_healthText;
	public Text p2_healthText;
	// Use this for initialization
	void Start(){
		p1_healthText.GetComponent<Text>();
		p2_healthText.GetComponent<Text>();
		p1_healthText.text = "Health = 100";
		p2_healthText.text = "Health = 100";
	}
	void LateUpdate()
	{
		GameObject player = GameObject.FindWithTag ("Player");

		if(player.name == "Player1")
			p1_healthText.text = "Health = " + player.GetComponent<PlayerHealth>().getHealth().ToString();
		if(player.name == "Player2")
			p2_healthText.text = "Health = " + player.GetComponent<PlayerHealth>().getHealth().ToString();
	}
	
}
