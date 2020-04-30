using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawn : MonoBehaviour
{
    int i = 0;
    public GameObject vehicle;
    public GameObject waypoint;
    public float spawnDirection;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > i)
        {
            i += 8;
            GameObject.Instantiate(vehicle, waypoint.transform.position, Quaternion.Euler(0f, spawnDirection, 0f));
        }
    }
}
