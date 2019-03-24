using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnGround : MonoBehaviour {
    public GameObject Ground2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            Ground2.transform.position = new Vector3(Ground2.transform.position.x, Ground2.transform.position.y, Ground2.transform.position.z+200);
      
        }

    }
}
