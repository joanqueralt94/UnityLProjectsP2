using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float leftBound = -25.0f;
    private float rightBound = 25.0f;

    GameObject controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy objects that are out of player view
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
            controller.GetComponent<GameController>().AnimalHit();
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            controller.GetComponent<GameController>().AnimalHit();
        }
        else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
            controller.GetComponent<GameController>().AnimalHit();
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
            controller.GetComponent<GameController>().AnimalHit();
        }
    }
}
