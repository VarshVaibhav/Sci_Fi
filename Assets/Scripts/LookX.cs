using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
    [SerializeField] private float _sensitivity = 1f;

    void Start()
    {
        Cursor.visible = false;
    }


    void Update()
    {
        float _mouseX = Input.GetAxis("Mouse X");
        // this below
        Vector3 newRotation = transform.localEulerAngles;
        newRotation.y += _mouseX * _sensitivity;
        transform.localEulerAngles = newRotation;
        // or alternative
        //transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + (_mouseX * _sensitivity), transform.localEulerAngles.z);
    }
}
