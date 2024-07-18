using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    [SerializeField] float moveForce;

    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizonalInput = Input.GetAxis("Horizontal");

        rigidbody.AddForce(Vector3.forward * horizonalInput * moveForce);

        // gameObject.transform.Translate(Vector3.forward * horizonalInput * moveForce * Time.deltaTime);
    }
}
