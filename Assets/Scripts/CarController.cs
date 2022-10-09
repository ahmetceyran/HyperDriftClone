using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] float carSpeed;
    [SerializeField] float maxSpeed;
    
    Vector3 moveVec;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveVec += transform.forward * carSpeed * Time.deltaTime;
        transform.position += moveVec * Time.deltaTime;

        moveVec = Vector3.ClampMagnitude(moveVec, maxSpeed);
    }
    
}
