using UnityEngine;
using System.Collections;

public class Jump3d : MonoBehaviour
{
    Rigidbody body;
    public float JumpForce;
    bool Jumping;
    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!Jumping)
            {
                body.AddForce(Vector3.up * JumpForce * 100);
                Jumping = true;
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        Jumping = false;
    }
}
