using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable/AudioManager")]//создат в меню по правой кнопке
public class SoundManeger : ScriptableObject

{
    [SerializeField] private AudioClip shootClip;//выстрел AudioClip - контейнер для звука
    [SerializeField] private AudioClip sheepHitClip;//удар
    [SerializeField] private AudioClip sheepDropClip;//падение
    private Vector3 cameraPosition;

    private void PlaySound(AudioClip audioClip)
    {
        cameraPosition = Camera.main.transform.position;
        AudioSource.PlayClipAtPoint(audioClip, cameraPosition);
    }
    public void PlayShootClip()
    {
        PlaySound(shootClip);
    }
    public void PlaySheepHitClip()
    {
        PlaySound(sheepHitClip);
    }
    public void PlayDropClip()
    {
        PlaySound(sheepDropClip);
    }
}
