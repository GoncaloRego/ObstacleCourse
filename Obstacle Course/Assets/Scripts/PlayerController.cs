using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    private Transform cachedTransform;

    void Start()
    {
        cachedTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;

        cachedTransform.Translate(movement);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit" && other.gameObject.tag != "Ground")
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
