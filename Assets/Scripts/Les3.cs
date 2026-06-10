using System;
using Unity.VisualScripting;
using UnityEngine;

public class Les3 : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private Bullet bulletprefab;
    private Vector3 pos;
    void Start()
    {

    }

    void Update()
    {
        float horizontalInput = -Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.forward, horizontalInput * Time.deltaTime * 100f);

        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * verticalInput * Time.deltaTime * speed);
        pos = new Vector3(transform.position.x, transform.position.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Bullet Bullet = Instantiate(bulletprefab, pos, transform.rotation);
            Bullet.direction = transform.right;
        }
    }


}
