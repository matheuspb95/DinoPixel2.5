using UnityEngine;
using System.Collections;

public class ShadowScript : LayerObject {
    public Movement move;
    public Transform Shadow;
    public float yOffset;
	// Use this for initialization
	void Start () {
        move = GetComponent<Movement>();
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
