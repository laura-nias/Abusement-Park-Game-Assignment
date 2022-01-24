using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    int health = 100;
    int lives = 3;
    bool dead = false;
    bool attackInc = false;
    bool tenHealth = false;

    private GameObject player;
   
    public GameObject gameoverScreen;
    public Text winningPlayer;

    GUIStyle style;
   
    // Use this for initialization
    void Start () {
        gameoverScreen.SetActive(false);
       
    }
	
	// Update is called once per frame
	void Update () {
        if ((health <= 0) &&(lives > 0))
        {
			loseLife();
			Debug.Log (lives);
        }
        if (lives == 0)
        {
            dead = true;
            gameoverScreen.SetActive(true);
        }

        player = GameObject.FindWithTag("Player");
        if ((player.name == "Player1") && !dead)
                winningPlayer.text = "Winner: Player 1";
        if ((player.name == "Player2") && !dead)
                winningPlayer.text = "Winner: Player 2";
        

    }
    public void Damage(int dmg)
    {
        if (health > 0 && attackInc == false)
        {
            health -= dmg;
        }
        if(health > 0 && attackInc == true)
        {
            dmg = 15;
            health -= dmg;
        }
    }
    public bool IsDead()
    {
        return dead;
    }
	public void loseLife()
	{
		lives--;
		health = 100;
	}
    public void FiftyHealth() //add 50 health?
    {
        if (health >= 51)
            health = 100;
        else
            health = health + 50;
    }
    public void TwentyFiveHealth()
    {
        if (health >= 76)
            health = 100;
        else
            health = health + 25;
    }
    public void TenHealth()
    {
        tenHealth = true;
        if (health >= 91)
            health = 100;
        else
            health = health + 10;
        
    }
    public void IncHealthOverTime()
    {
     
    }
	public int getLives()
	{
		return lives;
	}
	public int getHealth()
	{
		return health;
	}
    private void OnGUI() //need to make it check which player has collected to alter position of 10hp text
    {
        player = GameObject.FindWithTag("Player");
        GUI.contentColor = Color.green;
            if (tenHealth)
            {
                GUI.Label(new Rect(165, 27, 500, 200), "+10HP!"); //need to make text disappear
            }
        
    }

}
