using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField] private float _speed; // Adjust the speed as needed
    [SerializeField] private Vector3 _rotation;
    void Update()
    {
        // Apply the rotation to the stick
        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }

}
