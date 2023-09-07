using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class PostEffect : MonoBehaviour
{
    public Material wipeCircle;

    private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src,dest,wipeCircle);
    }
}
