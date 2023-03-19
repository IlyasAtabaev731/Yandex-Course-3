using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Clickable : MonoBehaviour
{

    [SerializeField] private AnimationCurve _scaleCurve;
    [SerializeField] private GoldCreator _goldCreator;
    [SerializeField] private int _goldNumber = 3;
    [SerializeField] private float _scaleTime = 0.25f;

    private int _coinsPerClick = 1;

    // ����� ���������� �� Interaction ��� ����� �� ������
    public void Hit()
    {
        for (int i = 0; i < _goldNumber; i++)
        {
            _goldCreator.CreateThrowedGold();
        }
        StartCoroutine(HitAnimation());
    }

    // �������� ��������� ����
    private IEnumerator HitAnimation()
    {
        for (float t = 0; t < 1f; t += Time.deltaTime / _scaleTime)
        {
            float scale = _scaleCurve.Evaluate(t);
            transform.localScale = Vector3.one * scale;
            yield return null;
        }
        transform.localScale = Vector3.one;
    }

    // ���� ����� ����������� ���������� �����, ���������� ��� �����
    public void AddCoinsPerClick(int value)
    {
        _coinsPerClick += value;
    }

}
