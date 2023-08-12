using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hit : MonoBehaviour
{
    public int energy = 3;
    [SerializeField]  SpriteRenderer spriteRenderer;
    [SerializeField] Sprite Nose1;
    [SerializeField] Sprite Nose2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        energy--;
        if (energy == 2)
        {
            spriteRenderer.sprite = Nose1;
        }
        if (energy == 1)
        {
            spriteRenderer.sprite = Nose2;
        }
        if (energy <= 0)
        {
           // SceneManager.LoadScene("GameOverScene");
            //Destroy(gameObject);
        }
    }
}
