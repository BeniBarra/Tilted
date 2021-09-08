using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody orbRB = GetComponent<Rigidbody>();
        orbRB.AddForce(Physics.gravity * orbRB.mass);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Goal")
        {
            Destroy(gameObject, .2f);
            Debug.Log("You Win");
        }
    }
}
