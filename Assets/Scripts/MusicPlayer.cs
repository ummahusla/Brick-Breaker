using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;

    void Awake() {

        if (instance != null) {
            Debug.Log("Destroyed dublicate game object");
            Destroy(gameObject);
        } else {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }

    }

}
