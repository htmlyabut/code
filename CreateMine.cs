using UnityEngine;

public class CreateMine : MonoBehaviour 
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    // This script will simply instantiate the Prefab when the game starts.
    void Update()
    {
		 if (Input.GetKeyDown(KeyCode.LeftShift))
         {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(myPrefab,transform.position, Quaternion.identity);
    }
}