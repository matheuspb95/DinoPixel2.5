using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
    public LayerObject shadow, self;
    public float xOffset, yOffset;
	// Use this for initialization
	void Start () {
        //layer = GetComponent<LayerObject>();

        //xOffset = transform.position.x - shadow.transform.position.x;
        //yOffset = transform.position.y - shadow.transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
        /*
        float x = xOffset + shadow.xPosition + shadow.InitialPosition.x;
        float y = yOffset + shadow.lPosition + shadow.InitialPosition.y;
        transform.position = new Vector3(x, y);
        */

        self.xPosition = shadow.xPosition;
        self.lPosition = shadow.lPosition;
	}
}
