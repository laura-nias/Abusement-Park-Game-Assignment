using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour {
	public GameObject player1, player2;
	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        Instantiate(player1, new Vector3(-5, 5, 0), Quaternion.identity);
        Instantiate(player2, new Vector3(5, 5, 0), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
