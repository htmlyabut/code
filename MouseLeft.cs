using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLeft : MonoBehaviour
{
	public bool isLeftButtonDown;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		isLeftButtonDown = Input.GetMouseButtonDown(0);
		if(Input.GetMouseButtonDown(0))
		{
		Debug.Log("The left mouse button was pressed");
		}

    }
}