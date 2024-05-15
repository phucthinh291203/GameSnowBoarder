using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseDetector : MonoBehaviour
{
    [SerializeField] float timeDelay = 0.5f;
    [SerializeField] ParticleSystem fallEffect;
    [SerializeField] AudioClip crash;
    bool hasCrash = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground" && hasCrash == false)
        {
            hasCrash = true;
            FindObjectOfType<PlayerController>().DisableMove();
            fallEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crash);
            Invoke("ReloadScene", timeDelay);
        }
    }

    void ReloadScene()
    {  
        SceneManager.LoadScene(0);
    }
}
