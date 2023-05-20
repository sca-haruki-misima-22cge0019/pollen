using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


/// <summary>
/// �_�C�A���O�̃A�j���[�V����
/// </summary>
public class AnimatedDialog : MonoBehaviour
{
    //�A�j���[�^�[
    [SerializeField] private Animator _animator;

    //�A�j���[�^�R���g���[���[�̃��C���[(�ʏ��0)
    [SerializeField] private int _layer;

    //IsOpen�̃t���O(�A�j���[�^�R���g���[���[���Œ�`�����t���O)
    private static readonly int ParamIsOpen = Animator.StringToHash("IsOpen");

    //�_�C�A���O�͊J���Ă��邩
    public bool IsOpen => gameObject.activeSelf;

    //�A�j���[�V���������ǂ���
    public bool IsTransiton { get; private set; }

    //�_�C�A���O���J��
    public void Open()
    {
        //�s������h�~
        if(IsOpen||IsTransiton)return;

        //�p�l�����̂��A�N�e�B�u�ɂ���
        gameObject.SetActive(true);

        //IsOpen�t���O�̃Z�b�g
        _animator.SetBool(ParamIsOpen,true);

        //�A�j���\�V�����ҋ@
        StartCoroutine(WaitAnimation("Shown"));
    }
    //����
    public void BACK()
    {
        if(!IsOpen||IsTransiton)return;

        _animator.SetBool(ParamIsOpen,false);

        StartCoroutine(WaitAnimation("Hidden",()=> gameObject.SetActive(false)));
    }

    //�J�A�j���[�V�����̑ҋ@�R���[�`��
    private IEnumerator WaitAnimation(string stateName, UnityAction onCompleted = null)
    {
        IsTransiton = true;

        yield return new WaitUntil(() =>
        {
            //�X�e�[�g���ω����A�A�j���[�V�������I���܂Ń��[�v
            var state = _animator.GetCurrentAnimatorStateInfo(_layer);
            return state.IsName(stateName)&&state.normalizedTime >= 1;
        });

        IsTransiton = false;

        onCompleted?.Invoke();
    }
}