using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
public class BosAnimation : MonoBehaviour
{
	[SerializeField]
	private string testAnimationName = "デフォルト2";

	/// <summary> ゲームオブジェクトに設定されているSkeletonAnimation </summary>
	private SkeletonAnimation skeletonAnimation = default;

	/// <summary> Spineアニメーションを適用するために必要なAnimationState </summary>
	private Spine.AnimationState spineAnimationState = default;

	private void Start()
	{
		// ゲームオブジェクトのSkeletonAnimationを取得
		skeletonAnimation = GetComponent<SkeletonAnimation>();

		// SkeletonAnimationからAnimationStateを取得
		spineAnimationState = skeletonAnimation.AnimationState;
	}

	private void Update()
	{
		// Aキーの入力でアニメーションを切り替えるテスト
		if (Input.GetKeyDown(KeyCode.A))
		{
			PlayAnimation();
		}
	}

	/// <summary>
	/// Spineアニメーションを再生
	/// testAnimationNameに再生したいアニメーション名を記載してください。
	/// </summary>
	private void PlayAnimation()
	{
		// アニメーション「testAnimationName」を再生
		spineAnimationState.SetAnimation(0, testAnimationName, true);
	}

}
