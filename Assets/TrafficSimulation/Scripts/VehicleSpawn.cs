using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawn : MonoBehaviour
{
    int i = 0;
    public int SpawnTimer;
    public GameObject vehicle1;
    public GameObject vehicle2;
    public GameObject waypoint;
    public float spawnDirection;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var chosenVehicle = Random.Range(1, 3);

        switch (chosenVehicle)
        {
            case (1):
                if (Time.time > i)
                {

                    i += SpawnTimer;
                    GameObject.Instantiate(vehicle1, waypoint.transform.position, Quaternion.Euler(0f, spawnDirection, 0f));
                }
                break;

            case (2):
                if (Time.time > i)
                {

                    i += SpawnTimer;
                    GameObject.Instantiate(vehicle2, waypoint.transform.position, Quaternion.Euler(0f, spawnDirection, 0f));
                }
                break;

            default:
                break;
        }
    }
}
