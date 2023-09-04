using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bgm : MonoBehaviour
{
    [SerializeField] GameObject Nose;
    hit hp;
    Animator bgmdown;
    void Start()
    {
        hp = Nose.GetComponent<hit>();
        bgmdown = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hp.energy <=0)
        {
            bgmdown.enabled = true;
        }
    }
}
