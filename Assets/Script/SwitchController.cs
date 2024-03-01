using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class SwitchController : MonoBehaviour
{



    private enum SwitchState
    {
        off,
        On,
        Blink
    }

    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;

    public float score;

    //public ScoreManager scoreManager;


    public AudioManager audioManager;
    public VFXManager vFXManager;


    private SwitchState state;

    private Renderer render;

    private bool isOn;

    private void Start()
    {
        render = GetComponent<Renderer>();

        Set(false);

        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider other)
    {



        if (other == bola)
        {
            
            Toggle();

        }


    }

    private void Set(bool active)
    {
        
        if (active == true)
        {
            state = SwitchState.On;
            render.material = onMaterial;
            audioManager.PlaySwitchOnSFX(transform.position);
            vFXManager.PlaySwitchVFX(transform.position);
            StopAllCoroutines();

        }
        else
        {
            state = SwitchState.off;
            render.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }


    }


    private void Toggle()
    {
        if (state == SwitchState.On)
        {
            Set(false);

            audioManager.PlaySwitchOffSFX(transform.position);
            vFXManager.PlaySwitchVFX(transform.position);
        }
        else
        {
            Set(true);
        }
    }


    


    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;
        for(int i = 0; i < times; i++) {
            render.material = onMaterial;
            audioManager.PlaySwitchOnSFX(transform.position);
            yield return new WaitForSeconds(0.5f);
            render.material = offMaterial;
            audioManager.PlaySwitchOffSFX(transform.position);
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.off;

        StartCoroutine(BlinkTimerStart(5));


    }

    private IEnumerator BlinkTimerStart(float time)
    {

        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }



}
