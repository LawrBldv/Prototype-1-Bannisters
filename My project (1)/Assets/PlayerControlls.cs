using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlls : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotateSpeed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed*(-1), 0);

        Vector3 forward = transform.TransformDirection((Vector3.forward)*(-1));
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
    }
}