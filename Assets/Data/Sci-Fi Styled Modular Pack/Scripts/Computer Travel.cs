using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComputerTravel : MonoBehaviour
{
    private GameObject player;
    public string proximaFase;
    public GameObject mensagem;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) < 2){
            mensagem.SetActive(true);
            if(Input.GetKey(KeyCode.E)){
                SceneManager.LoadScene(proximaFase);
            }
        }else{
            mensagem.SetActive(false);
        }
    }
}
