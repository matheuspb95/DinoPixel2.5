using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public float fireRate, bulletVelocity;
	public GameObject bulletPrefab;
	// Use this for initialization
	void Start () {
		StartCoroutine (Shoot ());
	}
	
	IEnumerator Shoot(){
		while(true){
			yield return new WaitForSeconds(fireRate);
			GameObject NewBullet = (GameObject)Instantiate (bulletPrefab);
			NewBullet.transform.parent = transform;
			NewBullet.transform.localPosition = Vector2.up * Random.Range(-1.5f, 1.5f);
			NewBullet.GetComponent<Rigidbody2D>().velocity = (Vector2.left * bulletVelocity);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
