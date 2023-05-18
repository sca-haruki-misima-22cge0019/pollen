using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


/// <summary>
/// ダイアログのアニメーション
/// </summary>
public class AnimatedDialog : MonoBehaviour
{
    //アニメーター
    [SerializeField] private Animator _animator;

    //アニメータコントローラーのレイヤー(通常は0)
    [SerializeField] private int _layer;

    //IsOpenのフラグ(アニメータコントローラー内で定義したフラグ)
    private static readonly int ParamIsOpen = Animator.StringToHash("IsOpen");

    //ダイアログは開いているか
    public bool IsOpen => gameObject.activeSelf;

    //アニメーション中かどうか
    public bool IsTransiton { get; private set; }

    //ダイアログを開く
    public void Open()
    {
        //不正操作防止
        if(IsOpen||IsTransiton)return;

        //パネル自体をアクティブにする
        gameObject.SetActive(true);

        //IsOpenフラグのセット
        _animator.SetBool(ParamIsOpen,true);

        //アニメ―ション待機
        StartCoroutine(WaitAnimation("Shown"));
    }
    //閉じる
    public void BACK()
    {
        if(!IsOpen||IsTransiton)return;

        _animator.SetBool(ParamIsOpen,false);

        StartCoroutine(WaitAnimation("Hidden",()=> gameObject.SetActive(false)));
    }

    //開閉アニメーションの待機コルーチン
    private IEnumerator WaitAnimation(string stateName, UnityAction onCompleted = null)
    {
        IsTransiton = true;

        yield return new WaitUntil(() =>
        {
            //ステートが変化し、アニメーションが終わるまでループ
            var state = _animator.GetCurrentAnimatorStateInfo(_layer);
            return state.IsName(stateName)&&state.normalizedTime >= 1;
        });

        IsTransiton = false;

        onCompleted?.Invoke();
    }
}