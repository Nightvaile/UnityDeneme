using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 vector;

    void Start()
    {
        vector =new Vector3 (0, 0.1f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vector);  
    }
}
