using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    public AudioManager audioManager;
    public VFXManager VFXManager;
    public ScoreManager scoreManager;
    public float score;

    private Renderer renderer;
    private Animator animator;

    private void Start()
    {
        renderer = GetComponent<Renderer>();

        renderer.material.color = color;

        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            animator.SetTrigger("hit");

            audioManager.PlaySFX(collision.transform.position, "Bumper");
            VFXManager.PlayVFX(collision.transform.position, "Bumper");
            scoreManager.AddScore(score);
        }
    }
}
