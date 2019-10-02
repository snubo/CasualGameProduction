using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackColliderTrigger : MonoBehaviour
{
    public GameObject myPrefab;
    public Transform newPos;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Debug.Log("Yoooo");
            GameObject temp = Instantiate(myPrefab, newPos.position, Quaternion.Euler(newPos.rotation.eulerAngles.x, -newPos.rotation.eulerAngles.y, newPos.rotation.eulerAngles.z));



            //temp.transform.position = GetComponentInChildren<Transform>().position;

            Debug.Log(GetComponentInChildren<Transform>().gameObject);
        }
    }
}
