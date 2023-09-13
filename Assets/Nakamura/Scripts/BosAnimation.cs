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
	[SerializeField] private AudioSource damage;
	[SerializeField] private AudioSource die;
	[SerializeField] private AudioClip damageSound;
	[SerializeField] private AudioClip dieSound;
	[SerializeField] private AudioSource bgm;
	[SerializeField] Fade fade;

	/// <summary> ゲームオブジェクトに設定されているSkeletonAnimation 
	private SkeletonAnimation skeletonAnimation = default;

	/// <summary> Spineアニメーションを適用するために必要なAnimationState 
	private Spine.AnimationState spineAnimationState = default;

	private bool isPlayingAnimation = false;


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

		if (bosHp.death && !isPlayingAnimation)
		{
			die.PlayOneShot(dieSound);
			time = 60.0f;
			isPlayingAnimation = true;
			AnimationName = "死亡";
			spineAnimationState.SetAnimation(0, AnimationName, false);
			TrackEntry trackEntry = spineAnimationState.GetCurrent(0);
			trackEntry.Complete += End;
		}

		if (bosHp.damage)
		{
			damage.PlayOneShot(damageSound);
			AnimationName = "スーパー花粉錠剤ダメージ";
			spineAnimationState.SetAnimation(0, AnimationName, false);
			TrackEntry trackEntry = spineAnimationState.GetCurrent(0);
			trackEntry.Complete += OnCompleteAnimation;
			bosHp.damage = false;
		}
	}

	private IEnumerator Loop()
	{
		BossHp bosHp = GetComponent<BossHp>();
		while (true)
		{
			if(bosHp.death)
            {
				yield break;
            }
			yield return new WaitForSeconds(time);
			if(!bosHp.death)
            {
				AnimationSecond();
			}
			

		}
	}

	private void AnimationSecond()
	{
		AnimationName = "デフォルト2";
		spineAnimationState.SetAnimation(0, AnimationName, false);
		TrackEntry trackEntry = spineAnimationState.GetCurrent(0);
		trackEntry.Complete += OnCompleteAnimation;
	}

	private void OnCompleteAnimation(TrackEntry trackEntry)
	{
		AnimationName = "デフォルト";
		spineAnimationState.SetAnimation(0, AnimationName, true);
		isPlayingAnimation = false; // アニメーション再生フラグをリセット
	}

	private void End(TrackEntry trackEntry)
	{
		fade.FadeIn(0.5f, () => print("フェードイン完了"));
		Invoke("Clear",0.6f);
		
	}

	void Clear()
    {
		SceneManager.LoadScene("GameClearSceneFinal");
	}
}