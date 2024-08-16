using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator _doorAnimator;
    void Start()
    {
        _doorAnimator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            _doorAnimator.SetTrigger("Open");
        }
    }
    // Update is called once per frame
    private void OnTriggerExit(Collider other){
        if(other.CompareTag("Player")){
            _doorAnimator.SetTrigger("Closed");
        }
    }
}
