using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectWall : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		var raycastHit = new RaycastHit ();
		var distance = 10f;
		Debug.DrawRay (transform.position, transform.forward * distance, Color.red);

		var layerMask = LayerMask.GetMask (LayerMask.NameToLayer ("Game"));
		layerMask = ~layerMask;

		if (Physics.Raycast(transform.position, transform.forward, out raycastHit, distance, layerMask))
		{
			Debug.Log ("I hit something.");
			if (raycastHit.collider.gameObject.name.ToLower().StartsWith("wall"))
			{
				Debug.Log("The wall.");
			}
		}
	}
}
