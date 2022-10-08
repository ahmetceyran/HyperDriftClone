using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] float carSpeed;
    
    Vector3 moveVec;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveVec += transform.forward * carSpeed * Time.deltaTime;
        transform.position += moveVec * Time.deltaTime;
    }
}
