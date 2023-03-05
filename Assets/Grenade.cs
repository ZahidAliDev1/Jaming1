using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Grenade : MonoBehaviour
{
    public float delay = 3f;
    public float radus = 5f;
    public float force = 2000f;
    float countDown;
    bool hasExploded = false;

    public GameObject explosionEffect;

    private void Start()
    {
        countDown = delay;
    }

    private void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    void Explode()
    {
        Debug.Log("Boom");
        Instantiate(explosionEffect, transform.position, transform.rotation);
       Collider[] colliders = Physics.OverlapSphere(transform.position, radus);
        
        foreach(Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radus);
            }
            destructable dest = nearbyObject.GetComponent<destructable>();
            if (dest != null)
            {
                dest.Destroy();
            }
        }


        Destroy(gameObject);

    }
}
