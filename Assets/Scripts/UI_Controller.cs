using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    [SerializeField]
    private Button m_StartButton = null;

    [SerializeField]
    private Button m_ClearButton = null;

    public static event Action StartEvent;

    public static event Action ClearEvent;

    public void Start()
    {
        m_StartButton.onClick.AddListener(() => StartEvent?.Invoke());
        m_ClearButton.onClick.AddListener(() => ClearEvent?.Invoke());
    }

    void OnDisable()
    {
        m_StartButton.onClick.RemoveListener(() => StartEvent?.Invoke());
        m_ClearButton.onClick.RemoveListener(() => ClearEvent?.Invoke());
    }
}
