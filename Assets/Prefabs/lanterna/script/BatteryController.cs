using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryController : MonoBehaviour
{

    private Transform flashlight;
    public float chargeBatteryvalue = 50;

    public float distanceToDetect = 2;
    public GameObject txtGetBattery;

    void Start()
    {
        flashlight = GameObject.FindGameObjectWithTag("Flashlight").transform;
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, flashlight.position) <= distanceToDetect)
        {
            txtGetBattery.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                flashlight.GetComponent<FlashLightController>().AddBattery(chargeBatteryvalue);
                txtGetBattery.SetActive(false);
                Destroy(gameObject);
            }
        }
        else
        {
            txtGetBattery.SetActive(false);
        }
    }
}
