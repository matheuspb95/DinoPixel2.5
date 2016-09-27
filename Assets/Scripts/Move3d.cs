using UnityEngine;
using System.Collections;

public class Move3d : MonoBehaviour {
    Rigidbody body;
    Animator anim;
    public float velocity;
    float normalScale;
    Dash DashScript;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        DashScript = GetComponent<Dash>();
        normalScale = transform.localScale.x;
    }
	
	// Update is called once per frame
	void Update () {
        if (!DashScript.Dashing)
        {
            Vector3 direction = Vector3.zero;

            if (Input.GetKey(KeyCode.UpArrow))
            {
                direction.z = velocity;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                direction.z = -velocity;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                direction.x = velocity;
                transform.localScale = new Vector3(normalScale, transform.localScale.y);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                direction.x = -velocity;
                transform.localScale = new Vector3(-normalScale, transform.localScale.y);
            }

            direction.y = body.velocity.y;
            body.velocity = direction;
        }
    }
}
