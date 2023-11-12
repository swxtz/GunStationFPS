using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{

    // Sensi do jogador
    public float sensX;
    public float sensY;

    public Transform orietation;

    float xRotation;
    float yRotation;


    void Start()
    {
        // tira o cursor da tela
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // define a sensibilidade da camera
        sensX = 50f;
        sensY = 50f;
    }

    // Update is called once per frame
    private void Update()
    {
        // pega o input do mouse
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        // isola as mudanças do mouse, suavisando a movimentação
        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //gira a camera e a orientação
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orietation.rotation = Quaternion.Euler(0, yRotation, 0);

    }
}
