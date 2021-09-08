using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    public Vector3 currentRotation;
    public Quaternion startQuaternion;
    public float lerpTime = 1f;
    public float rotateAmount = .1f;

    // Start is called before the first frame update
    void Start()
    {
        startQuaternion = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {


        currentRotation = GetComponent<Transform>().eulerAngles;

        if ((Input.GetKey(KeyCode.LeftArrow)) && (currentRotation.z <= 10 || currentRotation.z >= 348))
        {
            transform.Rotate(Vector3.forward * rotateAmount);
        }
        if ((Input.GetKey(KeyCode.RightArrow)) && (currentRotation.z >= 349 || currentRotation.z <= 11))
        {
            transform.Rotate(Vector3.back * rotateAmount);
        }
        if ((Input.GetKey(KeyCode.UpArrow)) && (currentRotation.x <= 10 || currentRotation.x >= 348))
        {
            transform.Rotate(Vector3.right * rotateAmount);
        }
        if ((Input.GetKey(KeyCode.DownArrow)) && (currentRotation.x >= 349 || currentRotation.x <= 11))
        {
            transform.Rotate(Vector3.left * rotateAmount);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, startQuaternion, Time.deltaTime * lerpTime);
        }
    }

}


//if ((Input.GetKey(KeyCode.LeftArrow)) && (currentRotation.z <= 10 || currentRotation.z >= 348))
//{
//    transform.Rotate(0, 0, 1);
//}
//if ((Input.GetKey(KeyCode.RightArrow)) && (currentRotation.z >= 349 || currentRotation.z <= 11))
//{
//    transform.Rotate(0, 0, -1);
//}
//if ((Input.GetKey(KeyCode.UpArrow)) && (currentRotation.x <= 10 || currentRotation.x >= 348))
//{
//    transform.Rotate(1, 0, 0);
//}
//if ((Input.GetKey(KeyCode.DownArrow)) && (currentRotation.x >= 349 || currentRotation.x <= 11))
//{
//    transform.Rotate(-1, 0, 0);
//}