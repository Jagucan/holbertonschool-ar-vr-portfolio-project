using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectedController : MonoBehaviour
{
    LayerMask mask;
    public float objectDistance = 1.5f;

    void Start()
    {
        mask = LayerMask.GetMask("Raycast Detect");
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, objectDistance, mask))
        {
            if (hit.collider.tag == "Chest Cover")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<SystemChest>().ChangeChestState();
                }
            }
        }
    }
}
