using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRB;
    public float bounceForce = 8;
    private AudioManager audioManager;

    private void Start() {
        audioManager = FindObjectOfType<AudioManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioManager.Play("bounce");
        playerRB.velocity = new Vector3(playerRB.velocity.x, bounceForce, playerRB.velocity.z);
        string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;

        if (materialName == "Floor (Instance)")
        {
            //
        }else if (materialName == "Wood (Instance)")
        {
            GameManager.gameOver = true;
            audioManager.Play("game over");
        }else if (materialName == "Rocks (Instance)" && !GameManager.levelComplete)
        {
            GameManager.levelComplete = true;
            audioManager.Play("win level");
        }
    }
}
