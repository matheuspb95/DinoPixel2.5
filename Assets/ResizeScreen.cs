using UnityEngine;
using System.Collections;

public class ResizeScreen : MonoBehaviour {
    void Awake()
    {
        Screen.SetResolution(1920, 1080, true);
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Screen.SetResolution(1920, 1080, true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Screen.SetResolution(1024, 768, true);
        }
    }
}
