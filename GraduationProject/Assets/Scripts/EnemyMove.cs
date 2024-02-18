using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 3f; // Tank�n hareket h�z�
    public float rotationSpeed = 30f; // Tank�n d�n�� h�z�
    public float circleRadius = 5f; // �emberin yar��ap�

    private Vector3 centerPoint; // �emberin merkezi
    private float angle = 0f; // Tank�n a��s�

    void Start()
    {
        // �emberin merkezini belirle
        centerPoint = transform.position + transform.forward * circleRadius;
    }

    void Update()
    {
        // D��man tank�n �emberde hareket etmesi
        angle += rotationSpeed * Time.deltaTime;
        if (angle >= 360f)
        {
            angle -= 360f;
        }
        float radians = angle * Mathf.Deg2Rad;
        Vector3 targetPosition = centerPoint + new Vector3(Mathf.Sin(radians), 0f, Mathf.Cos(radians)) * circleRadius;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Tank�n hedefe d�nmesi
        Vector3 direction = targetPosition - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}