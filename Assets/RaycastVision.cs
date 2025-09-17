using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastVision : MonoBehaviour
{
    [SerializeField] Vector3 rayOrigin;
    [SerializeField] Transform sightOrigin;
    [SerializeField] float rayDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(sightOrigin.position, sightOrigin.forward, out hitInfo, rayDistance))
        {
            Debug.Log(hitInfo.collider.gameObject);
        }
    }

    void OnDrawGizmos()
    {
        Color color = Color.red;
        Gizmos.color = color;
        Gizmos.DrawLine(sightOrigin.position, sightOrigin.position + sightOrigin.forward * rayDistance);
    }
}
