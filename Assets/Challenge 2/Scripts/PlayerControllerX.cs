using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float timeElapsed;
    private float cooldownSpawnTime = 0.5f;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Updating");
        if (timeElapsed > cooldownSpawnTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeElapsed = 0f;
            }
        }
        else
        {
            timeElapsed += Time.deltaTime;
        }        
    }
}
