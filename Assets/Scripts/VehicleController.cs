using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{

    public float verticalSpeed  = 10.0f;
    public float horizontalSpeed = 6f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * verticalInput);
        if(verticalInput == 1){
            transform.Rotate(Vector3.up, horizontalSpeed * Time.deltaTime * horizontalInput);
        }
        if(verticalInput == -1){
            transform.Rotate(Vector3.up, horizontalSpeed * Time.deltaTime * -horizontalInput);
        }
    }

}
