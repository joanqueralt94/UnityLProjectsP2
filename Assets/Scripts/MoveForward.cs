using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float projectileSpeed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moving forward the projectile in the direction at a certain speed per time
        transform.Translate(Vector3.forward * Time.deltaTime * projectileSpeed);
    }
}
