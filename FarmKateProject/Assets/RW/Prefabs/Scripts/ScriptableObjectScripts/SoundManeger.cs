using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable/AudioManager")]//������ � ���� �� ������ ������
public class SoundManeger : ScriptableObject

{
    [SerializeField] private AudioClip shootClip;//������� AudioClip - ��������� ��� �����
    [SerializeField] private AudioClip sheepHitClip;//����
    [SerializeField] private AudioClip sheepDropClip;//�������
    [SerializeField] private AudioClip arrowClickingClip;//�������
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
    public void PlayArrowClickingClip()
    {
        PlaySound(arrowClickingClip);
    }
}
