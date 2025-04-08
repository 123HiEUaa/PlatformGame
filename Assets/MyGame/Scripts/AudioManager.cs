using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource bgAudioSource;
    [SerializeField] private AudioSource efxAudioSource;

    [SerializeField] private AudioClip bgClip;
    [SerializeField] private AudioClip jumpClip;
    [SerializeField] private AudioClip coinClip;
    void Start()
    {
        PlayBackGroundMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayBackGroundMusic()
    {
        bgAudioSource.clip = bgClip;
        bgAudioSource.Play();
    }
    public void CoinSound()
    {
        efxAudioSource.PlayOneShot(coinClip);
    }
    public void JumpSound()
    {
        efxAudioSource.PlayOneShot(jumpClip);
    }
}
