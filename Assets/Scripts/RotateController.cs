using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject planetObject;
    public Vector3 RotationVector;

    // Update is called once per frame
    void Update()
    {
        planetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}
