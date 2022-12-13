using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public GameObject beat;
    public GameObject phrase1;
    public GameObject phrase2;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            phrase1.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKey(KeyCode.B))
        {
            phrase2.GetComponent<AudioSource>().Play();
        }
        if (!beat.GetComponent<AudioSource>().isPlaying)
        {
            text.SetActive(true);
        }
    }
}
