using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] float carSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float SteerAngle;
    
    float dragAmount = 0.99f;
    
    Vector3 moveVec;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveVec += transform.forward * carSpeed * Time.deltaTime;
        transform.position += moveVec * Time.deltaTime;

        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * SteerAngle * Time.deltaTime * moveVec.magnitude);

        moveVec *= dragAmount;
        moveVec = Vector3.ClampMagnitude(moveVec, maxSpeed);
    }
    
}
