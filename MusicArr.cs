using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicArr : MonoBehaviour
{
    public AudioClip[] Clips;
    public AudioSource source;
    public float NewClip, Timer;

    private void Start()
    {
      //  source = gameObject.GetComponent<AudioSource>();
    }
    private void Update()
    {
        Timer += Time.deltaTime;
        if (Timer>=NewClip+1)
        {
            ChangeCLIP();
            Timer = 0;

        }
    }
    void ChangeCLIP()
    {
        int clipNum = Random.Range(0, Clips.Length);
        if (!source.isPlaying)
        {
            source.loop = true;
            source.PlayOneShot(Clips[clipNum]);

        }
        NewClip = Clips[clipNum].length;
    }


}
