using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
    public bool Attacking;
    public float Range;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 Direction = new Vector3(transform.localScale.x, 0, 0);
            RaycastHit[] hits = Physics.SphereCastAll(transform.position, Range, Direction.normalized);
            foreach (RaycastHit hit in hits)
            {
                if (hit.rigidbody != null)
                {
                    if (hit.collider.CompareTag("Box"))
                    {
                        print("Atacking Enemy");
                    }
                }
            }
        }
	}
}
