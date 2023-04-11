using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 16.5f;
    private float spawnPosZ = 20;

    private float spawnMinZ = 0f;
    private float spawnMaxZ = 15.0f;
    private float spawnPosXMax = 20f;

    // Start is called before the first frame update
    void Start()
    {
        //Call initially a spawn random method that will be repeated every x seconds during the game
        InvokeRepeating("SpawnRandomAnimal", 2.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int randomDirection = Random.Range(0, 3);

        Vector3 spawnPosUp = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPosRight = new Vector3(spawnPosXMax, 0, Random.Range(spawnMinZ, spawnMaxZ));
        Vector3 spawnPosLeft = new Vector3(-spawnRangeX, 0, Random.Range(spawnMinZ, spawnMaxZ));

        if (randomDirection == 0)
        {
            Instantiate(animalPrefabs[animalIndex], spawnPosUp, animalPrefabs[animalIndex].transform.rotation);
        }
        else if (randomDirection == 1)
        {
            Instantiate(animalPrefabs[animalIndex], spawnPosRight, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0f, 90f, 0f));

        }
        else if (randomDirection == 2)
        {
            Instantiate(animalPrefabs[animalIndex], spawnPosLeft, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0f, -90f, 0f));
        }

    }
}
