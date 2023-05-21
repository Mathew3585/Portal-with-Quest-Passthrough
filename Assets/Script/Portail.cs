using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portail : MonoBehaviour
{

    public string tagetTag;
    public GameObject[] insidePortalGameObject;
    public int newLayer;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagetTag))
        {
            Vector3 targetvelocity = other.GetComponent<VelocityEstimator>().GetVelocityEstimate();

            float angle = Vector3.Angle(transform.forward, targetvelocity);


            if(angle < 90) 
            {
                foreach (var item in insidePortalGameObject)
                {
                    item.layer = newLayer;
                }
            }

        }
    }
}
