using UnityEngine;
using System.Collections;

public class Shadow : MonoBehaviour {
    public Transform shadow;
    float xOffset, zOffset;
    public float yOffset;
	// Use this for initialization
	void Start () {
        xOffset = transform.position.x - shadow.position.x;
        zOffset = transform.position.z - shadow.position.z;
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Physics.Raycast(transform.position, Vector3.down, out hit);
        float yPosition = shadow.position.y;
        if (hit.collider != null)
        {
            yPosition = hit.point.y + yOffset;
        }

        shadow.position = new Vector3(transform.position.x - xOffset, yPosition, transform.position.z - zOffset);
	}
}
