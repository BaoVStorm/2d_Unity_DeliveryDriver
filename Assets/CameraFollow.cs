using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject followThing;
    [SerializeField] int z_index = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(followThing != null) {
            this.transform.position = followThing.transform.position - new Vector3(0, 0, z_index);
        }
    }
}
