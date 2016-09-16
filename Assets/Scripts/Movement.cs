using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float velocity;
    public Transform Obj;
    public LayerObject layer;
	// Use this for initialization
	void Start () {
        layer = GetComponent<LayerObject>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
            layer.lPosition += velocity * Time.deltaTime;
            if(layer.lPosition > layer.MaxlPosition - layer.InitialPosition.y)
            {
                layer.lPosition = layer.MaxlPosition - layer.InitialPosition.y;
            }
        } else if (Input.GetKey (KeyCode.DownArrow)) {
            layer.lPosition -= velocity * Time.deltaTime;
            if(layer.lPosition < layer.MinlPosition - layer.InitialPosition.y)
            {
                layer.lPosition = layer.MinlPosition - layer.InitialPosition.y;
            }
        }

		if (Input.GetKey (KeyCode.LeftArrow)) {
            layer.xPosition -= velocity * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
            layer.xPosition += velocity * Time.deltaTime;
		}

        /*
        if (Input.GetMouseButton(0))
        {
            hPosition += velocity * Time.deltaTime;
        }else if (Input.GetMouseButton(1))
        {
            hPosition -= velocity * Time.deltaTime;
        }
        */
        
    }
}
