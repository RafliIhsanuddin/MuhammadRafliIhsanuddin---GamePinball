using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider bola;

    public KeyCode input;

    public Color color;

    public float maxTimeHold;

    public float maxForce;

    private Renderer render;

    private Renderer oriRender;

    private Color originalColor;

    public GameObject launcherFristColor;


    private bool isHold = false;


    // Start is called before the first frame update


    private void Start()
    {
        render = GetComponent<Renderer>();
        oriRender = launcherFristColor.GetComponent<Renderer>();
        originalColor = render.material.color;

    }



    private void OnCollisionStay(Collision collision)
    {


        if (collision.collider == bola)
        {
            ReadInput(bola);
        }


    }








    
    private void ReadInput(Collider collider)
    {

        if (UnityEngine.Input.GetKey(input) && !isHold)
        {
            
            StartCoroutine(StartHold(collider));

        }

    }


    private IEnumerator StartHold(Collider collider)
    {
        
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {


            force = Mathf.Lerp(0, maxForce, timeHold/maxTimeHold);

            //kalkulasi force
            yield return new WaitForEndOfFrame();
            render.material.color = color;

            timeHold += Time.deltaTime;

        }


        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;

        render.material.color = originalColor;
    }


}
