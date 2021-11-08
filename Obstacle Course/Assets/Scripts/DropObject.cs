using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    [SerializeField] float timeToWait = 1f;
    Rigidbody obstacleRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        obstacleRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            obstacleRigidbody.useGravity = true;
        }
    }
}
