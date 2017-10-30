using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	Transform target;

	//the target object
	private float speedMod = 10.0f;
	private Vector3 point;
	Vector3 mousePos;

	void Start ()
	{	//Set up things on the start method
		//point = target.position;//get target's coords
		//transform.LookAt (point);//makes the camera look to it
	}

	void Update ()
	{	//makes the camera rotate around "point" coords, rotating around its Y axis, 20 degrees per second times the speed modifier
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit; 
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit, 100.0f)) {
				point = hit.transform.position;
			}
		}
			
		if (Input.GetMouseButton (0)) {

				transform.LookAt (point);//makes the camera look to it
				transform.RotateAround (point, new Vector3 (0.0f, 1.0f, 0.0f), 20 * Time.deltaTime * speedMod);
			
		}

		if (Input.GetMouseButtonDown(1)) {
			mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		}

		if (Input.GetMouseButton (1)) {
			Camera.main.transform.position = (Camera.main.ScreenToWorldPoint (Input.mousePosition) - mousePos);

		}
	}
}
