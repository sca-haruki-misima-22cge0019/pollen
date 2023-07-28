using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
using Spine;
using UnityEngine.SceneManagement;
public class BosAnimation : MonoBehaviour
{
	[SerializeField] private string AnimationName = "デフォルト";
	[SerializeField] private float time = 20.0f;

	/// <summary> ゲームオブジェクトに設定されているSkeletonAnimation </summary>
	private SkeletonAnimation skeletonAnimation = default;

	/// <summary> Spineアニメーションを適用するために必要なAnimationState </summary>
	private Spine.AnimationState spineAnimationState = default;

	void Start()
	{
		// ゲームオブジェクトのSkeletonAnimationを取得
		skeletonAnimation = GetComponent<SkeletonAnimation>();
		// SkeletonAnimationからAnimationStateを取得
		spineAnimationState = skeletonAnimation.AnimationState;

		StartCoroutine("Loop");
	}

	void Update()
	{
		BossHp bosHp = GetComponent<BossHp>();
		Debug.Log(bosHp.death);
		if (bosHp.death)
		{
			AnimationName = "死亡";
			spineAnimationState.SetAnimation(0, AnimationName, true);
			TrackEntry trackEntry = spineAnimationState.SetAnimation(0, AnimationName, false);
			trackEntry.Complete += End;
			bosHp.death = false;
		}
		if (bosHp.damage)
		{
			AnimationName = "スーパー花粉錠剤ダメージ";
			spineAnimationState.SetAnimation(0, AnimationName, true);
			TrackEntry trackEntry = spineAnimationState.SetAnimation(0, AnimationName, false);
			trackEntry.Complete += OnCompleteAnimation;
			bosHp.damage = false;
		}

	}

	private IEnumerator Loop()
	{
		while (true)
		{
			BossHp bosHp = GetComponent<BossHp>();
			if (bosHp.death)
			{
				break;
			}
			yield return new WaitForSeconds(time);
			AnimationSecond();

		}
	}

	private void AnimationSecond()
	{
		AnimationName = "デフォルト2";
		spineAnimationState.SetAnimation(0, AnimationName, true);
		TrackEntry trackEntry = spineAnimationState.SetAnimation(0, AnimationName, false);
		trackEntry.Complete += OnCompleteAnimation;
	}

	private void OnCompleteAnimation(TrackEntry trackEntry)
	{
		//Debug.Log("アニメーション終了");
		AnimationName = "デフォルト";
		spineAnimationState.SetAnimation(0, AnimationName, true);
	}

	private void End(TrackEntry trackEntry)
	{
		SceneManager.LoadScene("GameClearSceneFinal");
	}
}
