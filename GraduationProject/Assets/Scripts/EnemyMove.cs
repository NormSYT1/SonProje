using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 3f; // Tankýn hareket hýzý
    public float rotationSpeed = 30f; // Tankýn dönüþ hýzý
    public float circleRadius = 5f; // Çemberin yarýçapý

    private Vector3 centerPoint; // Çemberin merkezi
    private float angle = 0f; // Tankýn açýsý

    void Start()
    {
        // Çemberin merkezini belirle
        centerPoint = transform.position + transform.forward * circleRadius;
    }

    void Update()
    {
        // Düþman tankýn çemberde hareket etmesi
        angle += rotationSpeed * Time.deltaTime;
        if (angle >= 360f)
        {
            angle -= 360f;
        }
        float radians = angle * Mathf.Deg2Rad;
        Vector3 targetPosition = centerPoint + new Vector3(Mathf.Sin(radians), 0f, Mathf.Cos(radians)) * circleRadius;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Tankýn hedefe dönmesi
        Vector3 direction = targetPosition - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}