using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    private void Awake() {
        // verifie s'il y a deja un music player pour ne pas en creer plus d'un en meme temps
        int numOfMusicPlayer = FindObjectsOfType<MusicPlayer>().Length;
        if(numOfMusicPlayer > 1) {
            Destroy(gameObject);
        }
        else
        { 
            DontDestroyOnLoad(gameObject);
        }

    }
}
