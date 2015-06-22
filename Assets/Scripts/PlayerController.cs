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
		var h = this.Relative.right;
		var v = this.Relative.forward;
		h.y = 0;
		v.y = 0;
		h.Normalize();
		v.Normalize();



		var move = h * Input.GetAxis ("Horizontal") + v * Input.GetAxis ("Vertical");

		move.Normalize ();
		
		this.rb.AddForce (move * this.Speed);
	}
}
