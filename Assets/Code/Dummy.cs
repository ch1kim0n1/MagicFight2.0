using UnityEngine;

public class Dummy : MonoBehaviour
{
    Animator anim;
    Rigidbody rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isHit", true);
            rb.isKinematic = false;
        }
    }
}
