﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public bool pressed;

    public void OnPointerDown(PointerEventData eventData)
    { 
            pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
            pressed = false;
    }

} 
