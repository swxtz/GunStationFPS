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
    }
}
