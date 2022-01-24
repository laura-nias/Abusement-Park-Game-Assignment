using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour {

    float attackTimer = 0;
    float attackCd = 0.3f;
	bool attacking = false;

    

    public Collider attackTrigger;
    
	void Start () {
        attackTrigger.enabled = false;
       
    }
	
	// Update is called once per frame
	void Update () {
        float fire0 = Input.GetAxis("Fire0");
        float fire1 = Input.GetAxis("Fire1");

        if ((Input.GetButtonDown("Fire"+GetComponent<PlayerManager>().playerNo))&&(!attacking))
        {
            attackTimer = attackCd;
            attacking = true;
            attackTrigger.enabled = true;
        }
        if((fire0 != 0) && (!attacking) || (fire1 != 0) && (!attacking))
        {
            attackTimer = attackCd;
            attacking = true;
            attackTrigger.enabled = true;
        }
        if ((Input.GetButtonDown("Range" + GetComponent<PlayerManager>().playerNo)) && (!attacking))
        {
            attackTimer = attackCd;
            attacking = true;
            attackTrigger.enabled = true;
            attackTrigger.gameObject.GetComponent<AttckTrigger>().ThrowWeapon();

        }
        
        if (attacking)
        {
            if(attackTimer>0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                attackTrigger.enabled = false;
            }

        }

    }

}
