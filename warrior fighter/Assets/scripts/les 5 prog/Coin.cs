using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour

{
    private Score addScore;
    private AudioSource source;
    private ParticleSystem ps;

    //r = GetComponent<Renderer>();
    void Start()
    {
        //r = GetComponent<Renderer>();
        ps = GetComponent<ParticleSystem>();
        source = GetComponent<AudioSource>();
        ps.Stop();
        addScore = GameObject.Find("score").GetComponent<Score>();
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("hallo");
        if (other.tag == "Player")
        {
            //addScore.ChangeScore();
           // r.enabled = false;
            GameObject.Destroy(gameObject, 1f);
            source.Play();
            //addScore.AddScore(5);
            ps.Play();
        }
    }
}
