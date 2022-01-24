using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttckTrigger : MonoBehaviour {
   // Rigidbody rb;
    int dmg = 10;
    

    void Start()
    {
       // rb.GetComponent<Rigidbody>();
    }

    public void ThrowWeapon ()
    {
       // rb.AddForce(new Vector3(70, 0, 0), ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider col)
    {
        if((!col.isTrigger)&&(col.CompareTag("Player"))&&(col.gameObject.name != transform.parent.gameObject.name))
        {
            Debug.Log(col.gameObject.name);
            Debug.Log(transform.parent.gameObject.name);
            col.GetComponentInParent<PlayerHealth>().Damage(dmg);
        }
    }
}
