using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float playerSpeed = 10.0f;

    public float xRange = 10.0f;
    public float zMinRange = 0f;
    public float zMaxRange = 15f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Limitating player position around the X axis with a xRange value
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        else if(transform.position.z < zMinRange)
        {
            transform.position = new Vector3(zMinRange, transform.position.y, transform.position.z);
        }
        else if(transform.position.z > zMaxRange)
        {
            transform.position = new Vector3(zMaxRange, transform.position.y, transform.position.z);
        }


        //Moving the Player with the Horizontal Unity Input at a certain speed
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime *  playerSpeed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * playerSpeed);


        //Shooting method every time Space is pressed down
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
