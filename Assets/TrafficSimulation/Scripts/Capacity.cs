using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Capacity : MonoBehaviour
{
    private int counter = 0;
    public int maxCapacity;
    public Text Add;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("AutonomousVehicle"))
        {
            other.gameObject.SetActive(false);
            switch (num)
            {
                case '1':
                   // other.gameObject.SetActive(false);
                    counter = counter + 1;
                    //Vehicles(counter);
                    break;
                case '2':
                    //other.gameObject.SetActive(false);
                    counter = counter - 1;
                    /*Sub(counter);*/
                    break;

            }
        }
    }

    public void Vehicles(int total)
    {
        Add.text = "Parking Lot:" + total.ToString() + "/" + maxCapacity;
    }

    public void Sub(int total)
    {
        Add.text = "Parking Lot:" + total.ToString() + "/" + maxCapacity;
    }
}

