using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    public ScoreHandler scoreScript;
    public AudioSource coinSound;
    // Start is called before the first frame update
    void Start()
    {
        coinSound = GetComponent<AudioSource>();
        scoreScript = FindObjectOfType<ScoreHandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coinSound.Play();
            scoreScript.increaseScore();
            //spawn particles
            Destroy(this.gameObject, .3f);
        }
    }
}
