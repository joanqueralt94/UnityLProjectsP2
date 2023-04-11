using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            Debug.Log("Game Over");   
        }        
        else if(col.GetComponent<Collider>().tag == "Food")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }

}
