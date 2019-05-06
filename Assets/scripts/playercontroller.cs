using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {
    protected Rigidbody rb;
    [SerializeField]
    float height = 5f;
    [SerializeField]
    float hSpeed = 10f;
    [SerializeField]
    float vSpeed = 10f;
    protected Animator anim;
    // Use this for initialization
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(Vector3.forward * vSpeed * Time.deltaTime);
        //float horizontalInput = Input.GetAxis("Horizontal") * hSpeed;
        ////float verticalInput = Input.GetAxis("Vertical") * speed;
        //Vector3 input = new Vector3(horizontalInput, rb.velocity.y, rb.velocity.z);
        //Vector3 rotatedInput = transform.TransformVector(input);
        //rb.velocity = rotatedInput;
        ////Debug.LogError(rotatedInput.ToString());

        //transform.Rotate(0, 0, 0);
        //Camera.main.transform.parent.Rotate(0, 0, 0);
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    rb.velocity = new Vector3(rb.velocity.x, height, rb.velocity.z);
        //    //Debug.LogError(rb.velocity.ToString());
        //    //Debug.LogError(this.transform.position);
        //    //anim.SetTrigger("Jump");
        //}
        ////anim.SetFloat("VerticalSpeed", verticalInput);
        ////anim.SetFloat("HorizontalSpeed", horizontalInput);
    }
}
