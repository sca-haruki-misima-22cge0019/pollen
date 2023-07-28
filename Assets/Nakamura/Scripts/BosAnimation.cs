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

	/// <summary> �Q�[���I�u�W�F�N�g�ɐݒ肳��Ă���SkeletonAnimation </summary>
	private SkeletonAnimation skeletonAnimation = default;

	/// <summary> Spine�A�j���[�V������K�p���邽�߂ɕK�v��AnimationState </summary>
	private Spine.AnimationState spineAnimationState = default;

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
		if (bosHp.death)
		{
			AnimationName = "���S";
			spineAnimationState.SetAnimation(0, AnimationName, true);
			TrackEntry trackEntry = spineAnimationState.SetAnimation(0, AnimationName, false);
			trackEntry.Complete += End;
			bosHp.death = false;
		}
		if (bosHp.damage)
		{
			AnimationName = "�X�[�p�[�ԕ����܃_���[�W";
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
		AnimationName = "�f�t�H���g2";
		spineAnimationState.SetAnimation(0, AnimationName, true);
		TrackEntry trackEntry = spineAnimationState.SetAnimation(0, AnimationName, false);
		trackEntry.Complete += OnCompleteAnimation;
	}

	private void OnCompleteAnimation(TrackEntry trackEntry)
	{
		//Debug.Log("�A�j���[�V�����I��");
		AnimationName = "�f�t�H���g";
		spineAnimationState.SetAnimation(0, AnimationName, true);
	}

	private void End(TrackEntry trackEntry)
	{
		SceneManager.LoadScene("GameClearSceneFinal");
	}
}
