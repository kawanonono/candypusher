using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    private AudioSource seAudioSource;
    public AudioClip[] audioClips;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SEPlay(int i)
    {
        // AddGomponent<Component–¼>();
        if (seAudioSource == null)
        {
            seAudioSource = this.gameObject.AddComponent<AudioSource>();
        }
        // se—p‚ÌAudioSource ‚É se‰¹Œ¹”z—ñ‚Ì0”Ô–Ú‚ð“n‚·
        seAudioSource.clip = audioClips[i];
        seAudioSource.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private AudioSource bgmaudioSource;
    public AudioClip[] bgmaudioClips;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void BGMPlay()
    {
        {
            bgmaudioSource = this.gameObject.AddComponent<AudioSource>();
        }

        bgmaudioSource.clip = bgmaudioClips[0];
        bgmaudioSource.Play();
        bgmaudioSource.loop = true;
    }
    
    private void Start()
    {
        BGMPlay();
    }

    // Update is called once per frame
}
