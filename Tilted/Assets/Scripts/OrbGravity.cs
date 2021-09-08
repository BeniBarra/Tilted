using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGravity : MonoBehaviour
{
    // Start is called before the first frame update

    public float PullRadius;
    public float GravitationalPull;
    public float MinRadius;
    public float DistanceMulitplier;

    public LayerMask LayersToPull;

    private void FixedUpdate()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, PullRadius, LayersToPull);

        foreach(var collider in colliders)
        {
            Vector3 direction = transform.position - collider.transform.position;

            if(direction.magnitude < MinRadius)
            {
                float distance = direction.sqrMagnitude * DistanceMulitplier + 1;

                Rigidbody rigidbody = collider.GetComponent<Rigidbody>();

                rigidbody.AddForce(direction.normalized * (GravitationalPull / distance) * rigidbody.mass * Time.fixedDeltaTime);
            }
        }
    }
}
