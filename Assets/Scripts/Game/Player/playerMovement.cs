using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public int moveSpeed = 150;


    Rigidbody rigidBody;
	SpriteRenderer sprite;

    Vector3 movement;
    int jumpNo = 0;

    void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
		sprite = GetComponent<SpriteRenderer> ();
        
    }
	
	// Update is called once per frame
	void Update()
    {
        
        movement.y = rigidBody.velocity.y;

        if ((Input.GetAxisRaw("Vertical" + GetComponent<PlayerManager>().playerNo) > 0) && (jumpNo == 0))
        {
            jumpNo++;
            rigidBody.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
        }

        if ((Input.GetAxisRaw("Vertical" + GetComponent<PlayerManager>().playerNo) == 0) && (jumpNo == 1))
        {
            jumpNo++;
        }

        if ((Input.GetAxisRaw("Vertical" + GetComponent<PlayerManager>().playerNo) > 0) && (jumpNo == 2))
        {
            jumpNo++;
            rigidBody.AddForce(new Vector3(0, 4, 0), ForceMode.Impulse);
        }
     
        movement.x = Input.GetAxis("Horizontal" + GetComponent<PlayerManager>().playerNo) * moveSpeed * Time.deltaTime;
        rigidBody.velocity = movement;

		if (rigidBody.velocity.x < 0) {
			sprite.flipX = true;
		}
		if (rigidBody.velocity.x > 0) {
			sprite.flipX = false;
		}
    }
    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.tag == "ground")||(col.gameObject.tag == "Player"))
        {
            jumpNo = 0;
        }
    }
}
