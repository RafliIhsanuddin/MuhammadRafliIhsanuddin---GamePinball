using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{

    public Collider bola;
    public float multiplier;
    public Color color;

    private Renderer rendererAja;
    private Animator animator;



    private void Start()
    {
        rendererAja = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        rendererAja.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola) {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();  
            bolaRig.velocity *= multiplier;

            //animasi
            animator.SetTrigger("hit");


        }
    }


}
