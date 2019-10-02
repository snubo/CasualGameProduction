using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    public bool triggerHit;
    public GameObject myPrefab;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        triggerHit = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        /*if(triggerHit)
        {
            Instantiate(myPrefab, GetComponentInChildren);
            triggerHit = false;
        }*/
        rb.MovePosition(rb.position + new Vector3(0, 0, -1));
    }
}
