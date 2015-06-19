using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float Speed;
	
	private Rigidbody rb;

	public Transform Relative;
	
	void Start ()
	{
		this.rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
		var h = this.Relative.right * Input.GetAxis ("Horizontal");
		var v = this.Relative.forward * Input.GetAxis ("Vertical");
		h.y = 0;
		v.y = 0;

		var move = h + v;


		
		this.rb.AddForce (move * this.Speed);
	}
}
