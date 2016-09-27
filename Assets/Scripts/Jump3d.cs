using UnityEngine;
using System.Collections;

public class Jump3d : MonoBehaviour
{
    Rigidbody body;
    public float JumpForce, JumpDelay;
    public bool Jumping;
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
                StartCoroutine(JumpDelayed());
                Jumping = true;
            }
        }
    }

    

    IEnumerator JumpDelayed()
    {
        yield return new WaitForSeconds(JumpDelay);
        body.AddForce(Vector3.up * JumpForce * 100);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Jumping = false;
    }
}
