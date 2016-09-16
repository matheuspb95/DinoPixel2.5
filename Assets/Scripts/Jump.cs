using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
    public float StartPoint, MaxPoint, EndPoint, JumpVelocity;
    public bool IsJumping, CanJump;
    public LayerObject layer;
    // Use this for initialization
    void Start ()
    {
        layer = GetComponent<LayerObject>();
        CanJump = true;
    }
	
	// Update is called once per frame
	void Update () {
        /*
        if (body.velocity.y < 0 && body.position.y < GetComponent<Movement>().zPosition)
        {
            IsJumping = false;
            body.velocity = Vector2.zero;
            body.gravityScale = 0;
        }
        */
        if (Input.GetButtonDown("Jump") && CanJump)
        {
            IsJumping = true;
            CanJump = false;
            StartPoint = layer.hPosition;
            EndPoint = StartPoint + MaxPoint;
        }

        if (IsJumping)
        {
            layer.hPosition += JumpVelocity * Time.deltaTime * Mathf.Exp(EndPoint - layer.hPosition);
        }else {
            if(layer.hPosition > StartPoint)
            {
                layer.hPosition -= JumpVelocity * Time.deltaTime * Mathf.Exp(EndPoint - layer.hPosition);
            }else
            {
                layer.hPosition = StartPoint;
                CanJump = true;
            }
        }

        if(layer.hPosition >= EndPoint - 0.1)
        {
            IsJumping = false;
        }
    }
}
