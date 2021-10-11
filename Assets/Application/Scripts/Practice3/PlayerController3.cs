using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnimator;
    private AudioSource playerAudio;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSE;
    public AudioClip crashSE;

    public float jumpForce;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnimator.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSE, 0.5f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        } 
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!!");
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSE, 0.5f);
        }
    }
}
