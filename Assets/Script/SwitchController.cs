using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{


    public Collider bola;

    private void OnTriggerEnter(Collider other)
    {


        if (other == bola)
        {
            Debug.Log("bola kena switch");


        }


    }



}
