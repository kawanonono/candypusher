using UnityEngine;
using TMPro;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

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

    private AudioSource bgmAudioSource;
    public AudioClip[] bgmAudioClips;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void BGMPlay()
    {
        {
            bgmAudioSource = this.gameObject.AddComponent<AudioSource>();
        }

        bgmAudioSource.clip = bgmAudioClips[0];
        bgmAudioSource.Play();
        bgmAudioSource.loop = true;
    }
    
    private void Start()
    {
        BGMPlay();
    }

    // Update is called once per frame
}
