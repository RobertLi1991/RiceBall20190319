using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMap : MonoBehaviour {
    public Texture texture1;
    public Texture texture2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
        {
            gameObject.GetComponent<Renderer>().material.mainTexture = texture1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.GetComponent<Renderer>().material.mainTexture = texture2;
        }
    }
}
