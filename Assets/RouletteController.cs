
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    float soundTimer = 0;

    AudioSource audioSource;

    void Start()
    {
        Application.targetFrameRate = 60;

        audioSource = GetComponent<AudioSource>();

        if (audioSource != null)
        {
            audioSource.playOnAwake = false;
            audioSource.loop = true;
        }
    }

    void Update()
    {
        // 點擊滑鼠或手機螢幕後開始旋轉
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10;
            soundTimer = 3.5f;

            if (audioSource != null)
            {
                audioSource.Stop();
                audioSource.pitch = 1.0f;
                audioSource.Play();
            }
        }

        // 輪盤旋轉
        transform.Rotate(0, 0, rotSpeed);

        // 輪盤逐漸減速
        rotSpeed *= 0.988f;

        // 輪盤停止
        if (rotSpeed < 0.01f)
        {
            rotSpeed = 0;
        }

        // 控制音效播放時間
        if (soundTimer > 0)
        {
            soundTimer -= Time.deltaTime;

            if (audioSource != null)
            {
                audioSource.pitch =
                    Mathf.Clamp(rotSpeed / 10f, 0.2f, 1f);

                if (soundTimer <= 0 || rotSpeed == 0)
                {
                    audioSource.Stop();
                }
            }
        }
    }
}
