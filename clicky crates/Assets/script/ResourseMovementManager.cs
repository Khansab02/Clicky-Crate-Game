using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourseMovementManager : MonoBehaviour
{

    private Rigidbody rb;
    private GameManager gameManager;
    public int pointval;
    public ParticleSystem Particle;

   


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        tossUP();
       
        
    }
    void tossUP()
    {
       rb.AddForce(Vector3.up * Random.Range(8, 12), ForceMode.Impulse);
        rb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
       
       
   
       
    }
    private void OnMouseDown()
    {
        if (gameManager.isgame)
        {
            Destroy(gameObject);
            gameManager.Updatescore(pointval);
            Instantiate(Particle, transform.position, Particle.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("skull") )
        {

            gameManager.game();

          

        }
    }

}
