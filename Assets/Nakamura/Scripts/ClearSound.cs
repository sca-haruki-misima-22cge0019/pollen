using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearSound : MonoBehaviour
{
    [SerializeField]AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("End",10.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void End()
    {
        Audio = GetComponent<AudioSource>();
        Audio.Play();
    }
}
