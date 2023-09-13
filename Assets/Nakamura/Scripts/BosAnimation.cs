using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
using Spine;
using UnityEngine.SceneManagement;
public class BosAnimation : MonoBehaviour
{
	[SerializeField] private string AnimationName = "�f�t�H���g";
	[SerializeField] private float time = 20.0f;
	[SerializeField] private AudioSource damage;
	[SerializeField] private AudioSource die;
	[SerializeField] private AudioClip damageSound;
	[SerializeField] private AudioClip dieSound;
	[SerializeField] private AudioSource bgm;
	[SerializeField] Fade fade;

	/// <summary> �Q�[���I�u�W�F�N�g�ɐݒ肳��Ă���SkeletonAnimation 
	private SkeletonAnimation skeletonAnimation = default;

	/// <summary> Spine�A�j���[�V������K�p���邽�߂ɕK�v��AnimationState 
	private Spine.AnimationState spineAnimationState = default;

	private bool isPlayingAnimation = false;


	void Start()
	{
		// �Q�[���I�u�W�F�N�g��SkeletonAnimation���擾
		skeletonAnimation = GetComponent<SkeletonAnimation>();
		// SkeletonAnimation����AnimationState���擾
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
			AnimationName = "���S";
			spineAnimationState.SetAnimation(0, AnimationName, false);
			TrackEntry trackEntry = spineAnimationState.GetCurrent(0);
			trackEntry.Complete += End;
		}

		if (bosHp.damage)
		{
			damage.PlayOneShot(damageSound);
			AnimationName = "�X�[�p�[�ԕ����܃_���[�W";
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
		AnimationName = "�f�t�H���g2";
		spineAnimationState.SetAnimation(0, AnimationName, false);
		TrackEntry trackEntry = spineAnimationState.GetCurrent(0);
		trackEntry.Complete += OnCompleteAnimation;
	}

	private void OnCompleteAnimation(TrackEntry trackEntry)
	{
		AnimationName = "�f�t�H���g";
		spineAnimationState.SetAnimation(0, AnimationName, true);
		isPlayingAnimation = false; // �A�j���[�V�����Đ��t���O�����Z�b�g
	}

	private void End(TrackEntry trackEntry)
	{
		fade.FadeIn(0.5f, () => print("�t�F�[�h�C������"));
		Invoke("Clear",0.6f);
		
	}

	void Clear()
    {
		SceneManager.LoadScene("GameClearSceneFinal");
	}
}