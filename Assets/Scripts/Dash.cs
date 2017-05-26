using UnityEngine;
using System.Collections;

public class Dash : MonoBehaviour
{
    public Vector3 Direction;
    public float Force, DashTime;
    Rigidbody body;

    public bool Dashing;
    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody>();
        Dashing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Direction = Vector2.zero;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Direction.x = -Force;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                Direction.x = +Force;
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                Direction.z = Force;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                Direction.z = -Force;
            }

            if (Direction != Vector3.zero)
            {
                Dashing = true;
                body.AddForce(Direction);
                StartCoroutine(StopDash());
            }
        }
    }

    IEnumerator StopDash()
    {
        yield return new WaitForSeconds(DashTime);
        Dashing = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (Dashing)
        {
            if (collision.rigidbody == null)
                return;
            float x = collision.transform.position.x - transform.position.x;
            float z = collision.transform.position.z - transform.position.z;
            Vector3 Impulse = new Vector3(x, 3, z);
            collision.rigidbody.AddForce(Impulse.normalized * Force / 1);
        }
    }
}
