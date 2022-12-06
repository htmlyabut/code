using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour
{
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}