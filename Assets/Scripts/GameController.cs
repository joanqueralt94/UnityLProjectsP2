using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int playerLifes = 3;
    public int playerScore = 0;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Debug.Log("Lives = " +  playerLifes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimalFeed(int value)
    {
        playerScore += value;
        Debug.Log("Score = " + playerScore);
    }

    public void AnimalHit()
    {
        if (playerLifes > 0)
        {
            --playerLifes;
            Debug.Log("Lives = " + playerLifes);

            if (playerLifes < 1)
            {
                Destroy(player);
                Debug.Log("Game Over!");
            }
        }
        
    }
}
