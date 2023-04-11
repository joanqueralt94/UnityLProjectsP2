using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    GameObject controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect collision between two colliders and Destroys it
    private void OnTriggerEnter(Collider col)
    {
        if(col.GetComponent<Collider>().tag == "Player")
        {
            controller.GetComponent<GameController>().AnimalHit();
        }        
        else if(col.GetComponent<Collider>().tag == "Food")
        {
            controller.GetComponent<GameController>().AnimalFeed();
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }

}
