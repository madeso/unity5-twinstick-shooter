using UnityEngine;
using System.Collections;

public class CameraFocus : MonoBehaviour {

	public GameObject Player;
	
	private Vector3 Offset;
	
	void Start ()
	{
		this.Offset = this.transform.position - this.Player.transform.position;
	}
	
	void LateUpdate ()
	{
		this.transform.position = this.Player.transform.position + this.Offset;
	}
}
