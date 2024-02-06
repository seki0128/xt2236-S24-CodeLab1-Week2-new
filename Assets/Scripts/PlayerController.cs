using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 mousePos;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        // update the position of the mouse
        Vector3 currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos = new Vector2(currentMousePos.x, currentMousePos.y);
    }

    private void OnMouseDown()
    {
        // When the player click the item, play the sound effect

    }

    private void OnMouseDrag()
    {
        transform.position = mousePos;
        Main.instance.audioManager.PlayEffect();
    }

    private void OnMouseUp()
    {
        throw new NotImplementedException();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Good"))
        {
            Main.instance.flowController.GoToNextLevel();
        }
    }
}
