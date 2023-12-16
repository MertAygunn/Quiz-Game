using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image _timerImg;

    private float _currentTime;
    [SerializeField] private float _duration;
    void Start()
    {
        _currentTime = _duration;
        StartCoroutine(UpdateTime());
    }
    
    private IEnumerator UpdateTime()
    {
        while(_currentTime > 0)
            {
            _timerImg.fillAmount = Mathf.InverseLerp(0, _duration, _currentTime);
            yield return new WaitForSeconds(1f);
            _currentTime--;
        }
        yield return null;
    }
}
