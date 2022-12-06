using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active_bool : MonoBehaviour
{
	public bool active;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
	if(active)
	{
		placed = 1;
	}
	else
	{
		placed = 0;
	}
    }
}