using System;
using UnityEngine;

public class Les3 : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    void Start()
    {

    }

    void Update()
    {
        float horizontalInput = -Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.forward, horizontalInput * Time.deltaTime * 100f);

        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * verticalInput * Time.deltaTime * speed);
    }


}
