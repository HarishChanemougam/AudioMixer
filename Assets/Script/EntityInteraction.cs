using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class EntityInteraction : MonoBehaviour
{
    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward*2f);
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, 2f))
        {

        }
    }
}
