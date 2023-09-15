using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomRotate : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f; // Adjust the speed as needed
    private float horizontalInput;
    //[SerializeField] private Vector3 _rotation;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // Create a rotation vector based on horizontal input
        //Vector3 rotation = Vector3.right * horizontalInput * _speed * Time.deltaTime;

        // Apply the rotation to the stick
        transform.Rotate(Vector3.right, horizontalInput * _speed * Time.deltaTime);
    }
}
