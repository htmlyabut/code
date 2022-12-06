using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAxis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
	float horizontalValue = Input.GetAxis("Mouse X");
	float verticalValue = Input.GetAxis("VMouse Y");
	}
}