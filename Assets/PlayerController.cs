using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float rotateInput;
    float moveInput;
    int moveLook;
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateInput = Input.GetAxis("Horizontal");
        moveInput = Input.GetAxis("Vertical");
        moveLook = rotateInput == 0 ? 1 : 0;


        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * moveInput);
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * rotateInput);
    }
}
