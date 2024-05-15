using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem particleSystem;
   

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
           particleSystem.Stop();
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            particleSystem.Play();
        }
    }

}
