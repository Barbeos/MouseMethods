using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitOnMouseDrag : MonoBehaviour {
	public float speed;

	void LateUpdate(){
        if (Input.GetMouseButton(2))
        {
            transform.position -= new Vector3 (Input.GetAxis("Mouse X") * speed * Time.deltaTime, Input.GetAxis("Mouse Y") * speed * Time.deltaTime, 0.0f);
             

        }




    }

}
