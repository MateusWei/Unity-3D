using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public float speed;
    private Transform target;
    void Start()
    {
        target = Camera.main.transform;
    }

    
    void Update()
    {
        transform.position = target.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, speed * Time.deltaTime);
    }
}
