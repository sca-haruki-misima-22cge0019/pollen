using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedDialog : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    [SerializeField] private int _layer;

    private static readonly int ParamIsOpen = Animator.StringToHash("IsOpen");

    public bool IsOpen => gameObject.activeSelf;

    public bool IsTransiton { get; private set; }

    public
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
