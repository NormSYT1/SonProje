using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
  
    public float moveSpeed = 5f; // Tankýn ileri/geri hareket hýzý
    public float rotationSpeed = 50f; // Tankýn dönüþ hýzý

    private Rigidbody tankRigidbody;
    public TMP_Text timeText;
    private float time = 300f;
    private void Awake()
    {
        // Tankýn RigidBody bileþenini alýyoruz
        tankRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Hareket ve dönüþ fonksiyonlarýný çaðýrýyoruz
        if (time > 0)
        {
            time -= Time.deltaTime;
            int timeInteger = Mathf.FloorToInt(time);
            timeText.text = "Time: " + timeInteger.ToString();
            Move();
            Rotate();
        }
        else
        {
            Time.timeScale = 0f;
        }


    }

    private void Move()
    {
        // Ýleri/geri hareket için input deðerini alýyoruz
        float moveInput = Input.GetAxis("Vertical");
        // Hareket yönünü belirliyoruz
        Vector3 moveDirection = transform.forward * moveInput;
        // Hareket yönünü RigidBody üzerinden uyguluyoruz
        tankRigidbody.velocity = moveDirection * moveSpeed;
    }

    private void Rotate()
    {
        // Tankýn dönüþü için input deðerini alýyoruz
        float rotateInput = Input.GetAxis("Horizontal");
        // Dönüþ yönünü belirliyoruz
        float rotationAmount = rotateInput * rotationSpeed * Time.fixedDeltaTime;
        // Yeni rotasyonu hesaplýyoruz
        Quaternion rotation = Quaternion.Euler(0f, rotationAmount, 0f);
        // Tanký döndürüyoruz
        tankRigidbody.MoveRotation(tankRigidbody.rotation * rotation);
    }
}


