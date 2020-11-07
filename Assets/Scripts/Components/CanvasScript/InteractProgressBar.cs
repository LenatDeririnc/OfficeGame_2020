using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractProgressBar : MonoBehaviour, IInit
{
    private Image _image;
    private float _fillProgress = 0;
    private IEnumerator FillProgressEnumerator;
    [SerializeField] private float _increaseSpeed = 0.1f;
    private InteractableItem m_currentItem;

    private float FillProgress
    {
        get => _fillProgress;
        set
        {
            _fillProgress = Mathf.Clamp(value, 0, 1);
            _image.fillAmount = _fillProgress;
        }
    }

    public void INIT()
    {
        // throw new NotImplementedException();
    }

    public void GET()
    {
        _image = GetComponent<Image>();
    }

    public void AFTER_INIT()
    {
        FillProgress = 0;
        BaseInputManager.Interface.Interact.canceled += c => StopProgress();
    }

    private IEnumerator _fillProgressEnumerator()
    {
        while (FillProgress < 1)
        {
            FillProgress += _increaseSpeed * Time.deltaTime;
            yield return null;
        }

        if (m_currentItem != null)
        {
            m_currentItem.InteractActions();
            StopProgress();
        }
    }

    public void StartProgress(InteractableItem item)
    {
        m_currentItem = item;
        _increaseSpeed = m_currentItem.m_interactSpeed;;
        FillProgressEnumerator = _fillProgressEnumerator();
        StartCoroutine(FillProgressEnumerator);
    }

    public void StopProgress()
    {
        if (FillProgressEnumerator != null)
        {
            StopCoroutine(FillProgressEnumerator);
            FillProgressEnumerator = null;
            FillProgress = 0;
        }
    }

    
}
