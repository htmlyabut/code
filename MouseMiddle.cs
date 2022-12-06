using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLeft : MonoBehaviour
{
	public bool isMiddleButtonDown;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		isMiddleButtonDown = Input.GetMouseButtonDown(1);
		if(Input.GetMouseButtonDown(0))
		{
		Debug.Log("The right mouse button was pressed");
		}

    }
}