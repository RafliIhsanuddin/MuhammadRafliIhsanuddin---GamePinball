using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{

    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;

    private Renderer rendererAja;
    private Animator animator;



    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;


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

            //playsfx
            audioManager.PlaySFX(collision.transform.position);



            vfxManager.PlayVFX(collision.transform.position);




            scoreManager.AddScore(score);


        }
    }


}
