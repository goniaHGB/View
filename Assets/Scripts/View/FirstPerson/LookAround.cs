﻿using UnityEngine;

namespace View.FirstPerson
{
    public class LookAround : MonoBehaviour
    {

        public float mouseSensitiviyt = 100f;
        public Transform playerBody;

        float xRotation = 0f;

        // Start is called before the first frame update
        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        // Update is called once per frame
        void Update()
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitiviyt * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitiviyt * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation,-90f,90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f,0f);

            playerBody.Rotate(Vector3.up*mouseX);
        }
    }
}
