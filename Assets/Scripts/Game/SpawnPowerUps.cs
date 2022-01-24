using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUps : MonoBehaviour {
	public GameObject extraHealthPrefab, twentyFiveHealthPrefab, tenHealthPrefab, incHealth, incAttack;
    GameObject powerUp;
    void Start(){
		InvokeRepeating ("SpawnRandPowerUp", 1.0f, 7.0f);
	}
	void SpawnRandPowerUp(){
        int rand = Random.Range(0, 5);
        switch (rand)
        {
            case 0:
                powerUp = extraHealthPrefab;
                break;
            case 1:
                powerUp = twentyFiveHealthPrefab;
                break;
            case 2:
                powerUp = tenHealthPrefab;
                break;
            case 3:
                powerUp = incHealth;
                break;
            case 4:
                powerUp = incAttack;
                break;
        }
        Instantiate(powerUp, new Vector3(Random.Range(-6f, 6f),8,0), Quaternion.identity);
	}

}