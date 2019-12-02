using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    public Transform copyTarget;
    void FixedUpdate()
    {
        if (copyTarget != null)
        {
            copyTarget.position = transform.position;
        }
    }
}
