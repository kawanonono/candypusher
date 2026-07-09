using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource secondAudioSource;
    public AudioClip[] seAudioClips;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SEPlay()
    {
        audioSource.clip = seAudioClips[0];
        if (audioSource.isPlaying == false)
        {
            audioSource.Play();
        }
        else
        {
            secondAudioSource.clip = seAudioClips[0];
            secondAudioSource.Play();
        }
            audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
