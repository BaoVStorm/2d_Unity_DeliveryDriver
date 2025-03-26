using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Driver : MonoBehaviour
{
    [SerializeField]
    float steerSpeed = 200f;
    [SerializeField]
    float moveSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        // this.transform.Rotate(0, 0, 10);
    }

    // Update is called once per frame
    void Update()
    {   
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // if(moveAmount > 0f)
            this.transform.Rotate(0, 0, -steerAmount);
        
        this.transform.Translate(0, moveAmount, 0);
    }
}
