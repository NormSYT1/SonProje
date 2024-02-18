using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Bullet : MonoBehaviour
{
    public GameObject effect;
    public GameObject explosionEffect;
    PlayerController control;
    void Start()
    {
        control = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")  
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            control.score++;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        Instantiate(effect, transform.position, transform.rotation);
    }
}
