using UnityEngine;
using System.Collections;

public class LayerObject : MonoBehaviour {
    public int Layer;
    public float hPosition, lPosition, xPosition, MaxlPosition, MinlPosition;
    SpriteRenderer Sprite;
    Rigidbody2D body;
    public Vector3 InitialPosition;
    // Use this for initialization
    public void Start () {
        InitialPosition = transform.position;
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        /*
        Layer = -Mathf.RoundToInt(transform.position.y * 10);
        Sprite.sortingOrder = Layer;
        */
        Vector2 newPosition = new Vector3(InitialPosition.x + xPosition, InitialPosition.y + (lPosition + hPosition));
        Vector2 diff = (Vector3)newPosition - transform.position;
        body.velocity = diff;
    }
    
}
