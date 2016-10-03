using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
    public float Range, Force;
    public ParticleSystem particles;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            particles.Emit(200);
            RaycastHit[] hits = Physics.SphereCastAll(transform.position, Range, Vector3.down);
            foreach(RaycastHit hit in hits)
            {
                if(hit.rigidbody != null)
                {
                    if (hit.collider.CompareTag("Box"))
                    {
                        float x = hit.transform.position.x - transform.position.x;
                        float z = hit.transform.position.z - transform.position.z;
                        Vector3 Impulse = new Vector3(x, 1, z);
                        hit.rigidbody.AddForce(Impulse.normalized * Force);
                    }
                }
            }
        }
	}
}
