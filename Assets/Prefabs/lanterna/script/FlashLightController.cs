using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class FlashLightController : MonoBehaviour
{
    public TextMeshProUGUI tmpBattery;
    public AudioSource turnLightSound;

    public float minSpotAngle = 5;
    public float maxSpotAngle = 71;
    public float multiplier = 5;
    public float reduceBatteryValue = 10;

    private float batteryValue = 100;
    private Light light;

    void Start()
    {
        light = GetComponentInChildren<Light>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            TurnFlashLight();

        if (light.enabled)
        {
            //SetFocusLight();
            ReduceBattery();
        }

        SetUI();
    }

    void TurnFlashLight()
    {
        if (batteryValue != 0)
        {
            light.enabled = !light.enabled;
            turnLightSound.Play();
        }
        else
        {
            light.enabled = false;
        }
    }

    void SetFocusLight()
    {
        light.spotAngle = Mathf.Clamp(light.spotAngle += Input.GetAxis("Mouse ScrollWheel") * multiplier, 5, 71);
    }

    void ReduceBattery()
    {
        batteryValue = Mathf.Clamp(batteryValue -= reduceBatteryValue * Time.deltaTime, 0, 100);
    }

    void SetUI()
    {
        tmpBattery.text = batteryValue.ToString("N0");
    }

    public void AddBattery(float value){
         batteryValue = Mathf.Clamp(batteryValue += value , 0, 100);     
    }
}
