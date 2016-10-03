using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {
    Animator anim;
    Move3d move;
    Jump3d jump;
    Dash dash;
    Attack attack;
    public bool Pressed, Walking, Jumping;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        move = GetComponent<Move3d>();
        jump = GetComponent<Jump3d>();
        dash = GetComponent<Dash>();
        attack = GetComponent<Attack>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!jump.Jumping && !dash.Dashing && !attack.Attacking)
        {
            if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) &&
               !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
            {
                Pressed = false;
            }
            else
            {
                Pressed = true;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow) ||
               Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (!Walking)
                {
                    Walking = true;
                    anim.SetTrigger("Walk");
                }
            }
            if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow) ||
               Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
            {
                if (!Pressed)
                {
                    anim.SetTrigger("Idle");
                    Walking = false;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && !Jumping)
        {
            Jumping = true;
            anim.SetTrigger("Jump");
            anim.SetBool("Jumping", true);
        }

        if(Pressed && Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Dash");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Attack");
        }
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Jumping = false;
            anim.SetBool("Jumping", false);
            if (Walking)
            {
                anim.SetTrigger("Walk");
            }
        }
    }
}
