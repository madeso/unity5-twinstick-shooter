using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float Speed;
	
	private Rigidbody rb;
	
	void Start ()
	{
		this.rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
		var h = Input.GetAxis ("Horizontal");
		var v = Input.GetAxis ("Vertical");
		var move = new Vector3 (h, 0.0f, v);
		
		this.rb.AddForce (move * this.Speed);
	}
}
