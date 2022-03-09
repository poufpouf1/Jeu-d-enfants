using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    public float BlastPower = 5;

    public GameObject Cannonball;
    public Transform ShotPoint;

    public Animator animator;

    public float fireRate = 0.5f;
    private float nextFire = 0f;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            GameObject CreatedCannonball = Instantiate(Cannonball, ShotPoint.position, ShotPoint.rotation);
            CreatedCannonball.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * BlastPower;
            animator.SetBool("isShooting", true);

            FindObjectOfType<AudioManager>().Play("Cannon");
        }
        else
        {
            animator.SetBool("isShooting", false);
        }
    }
}
