using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int playerLives = 3;
    public int playerScore = 0;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Debug.Log("Lives = " +  playerLives);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimalFeed()
    {
        ++playerScore;
        Debug.Log("Score = " + playerScore);
    }

    public void AnimalHit()
    {
        if (playerLives > 0)
        {
            --playerLives;
            Debug.Log("Lives = " + playerLives);

            if (playerLives < 1)
            {
                Destroy(player);
                Debug.Log("Game Over!");
            }
        }
        
    }
}
