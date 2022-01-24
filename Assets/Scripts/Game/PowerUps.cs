using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {

    int dmg = 10;
    bool attackInc = false;

    void Start () {
	}

	void Update () {

	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
            switch (gameObject.tag)
            {
                case "pu_50Health":
                    other.gameObject.GetComponent<PlayerHealth>().FiftyHealth();
                    break;

                case "pu_25Health":
                    other.gameObject.GetComponent<PlayerHealth>().TwentyFiveHealth();
                break;

                case "pu_10Health":
                    other.gameObject.GetComponent<PlayerHealth>().TenHealth();
                    break;
                case "pu_HealthIncrease":
                    other.gameObject.GetComponent<PlayerHealth>().IncHealthOverTime();
                    break;
                case "pu_AttackIncrease":
                    other.gameObject.GetComponent<PlayerHealth>().Damage(dmg);
                    break;
            }
			Destroy(gameObject);
		}
	}





}

