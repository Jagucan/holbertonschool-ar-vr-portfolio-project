using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SystemChest : MonoBehaviour
{
    public bool chestOpen = false;
    public float chestOpenAngle = -50f;
    public float chestCloseAngle = 0.0f;
    public float smooth = 3.0f;

    void Update()
    {
        if (chestOpen)
        {
            Quaternion targetRotation = Quaternion.Euler(chestOpenAngle, 0, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, Time.deltaTime * smooth);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(chestCloseAngle, 0, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, Time.deltaTime * smooth);
        }
    }

    public void ChangeChestState()
    {
        chestOpen = !chestOpen;
    }
}
