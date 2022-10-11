using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] float carSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float SteerAngle;
    [SerializeField] float Traction;
    
    float dragAmount = 0.99f;
    
    [SerializeField] private Transform lw, rw;

    Vector3 rotVec;
    Vector3 moveVec;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveVec += transform.forward * carSpeed * Time.deltaTime;
        transform.position += moveVec * Time.deltaTime;

        rotVec += new Vector3(0, Input.GetAxis("Horizontal"), 0);

        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * SteerAngle * Time.deltaTime * moveVec.magnitude);

        moveVec *= dragAmount;
        moveVec = Vector3.ClampMagnitude(moveVec, maxSpeed);
        moveVec = Vector3.Lerp(moveVec.normalized, transform.forward, Traction * Time.deltaTime) * moveVec.magnitude;

        rotVec = Vector3.ClampMagnitude(rotVec, SteerAngle);

        lw.localRotation = Quaternion.Euler(rotVec);
        rw.localRotation = Quaternion.Euler(rotVec);
    }
    
}
