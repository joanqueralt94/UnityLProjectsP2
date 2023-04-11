using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    public float playerSpeed = 15.0f;
    private Vector3 projectileOffset = new Vector3(0, 0, 2);

    private float xRange = 16.5f;
    private float zMinRange = -1.5f;
    private float zMaxRange = 15.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        PlayerShooting();
    }

    private void PlayerMovement()
    {
        //Moving the Player with the Horizontal Unity Input at a certain speed
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);

        //Moving the Player with the Vertical Unity Input at a certain speed
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * playerSpeed);

        //Limitating player position around the X axis with a xRange value
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.z < zMinRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMinRange);
        }
        else if (transform.position.z > zMaxRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMaxRange);
        }
    }

    private void PlayerShooting()
    {
        //Shooting method every time Space is pressed down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile
            Instantiate(projectilePrefab, transform.position + projectileOffset, projectilePrefab.transform.rotation);
        }
    }
}
