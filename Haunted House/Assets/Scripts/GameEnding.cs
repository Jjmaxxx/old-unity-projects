using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public GameObject Player;
    public AudioSource exitAudio;
    public AudioSource caughtAudio;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    public CanvasGroup caughtBackgroundImageCanvasGroup;
    float Timer;
    public float displayImageDuration = 1f;
    bool IsPlayerAtExit;
    bool IsPlayerCaught;
    bool hasAudioPlayed;
    void OnTriggerEnter(Collider other) {
        if(other.gameObject == Player){
            IsPlayerAtExit = true;
        }
    }
    void Update(){
        if(IsPlayerAtExit){
            EndLevel(exitBackgroundImageCanvasGroup, false,exitAudio);
        }
        else if(IsPlayerCaught){
            EndLevel(caughtBackgroundImageCanvasGroup, true,caughtAudio);
        }
    }
    void EndLevel(CanvasGroup imageCanvasGroup, bool doRestart, AudioSource audioSource){
        if(!hasAudioPlayed){
            audioSource.Play();
            hasAudioPlayed = true;
        }
        Timer += Time.deltaTime;
        imageCanvasGroup.alpha = Timer/fadeDuration;
        if(Timer > fadeDuration + displayImageDuration){
           if(doRestart){
                SceneManager.LoadScene(0);
            }
            else{
                Application.Quit();
            }

        }
      
    }
    public void CaughtPlayer(){
        IsPlayerCaught = true;
    }

}
