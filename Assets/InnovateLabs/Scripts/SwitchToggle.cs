﻿//using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToggle : MonoBehaviour
{
    //[SerializeField] RectTransform uiHandleRectTransform;
    //[SerializeField] RectTransform labelRectTransform;
    //[SerializeField] Color backgroundActiveColor;
    //[SerializeField] Color handleActiveColor;
    //[SerializeField] TextMeshProUGUI label;

    //Image backgroundImage, handleImage;

    //Color backgroundDefaultColor, handleDefaultColor;

    //Toggle toggle;

    //Vector2 handlePosition;
    //Vector2 labelPosition;

    //void Awake()
    //{
    //    toggle = GetComponent<Toggle>();

    //    handlePosition = uiHandleRectTransform.anchoredPosition;
    //    labelPosition = labelRectTransform.anchoredPosition;

    //    backgroundImage = uiHandleRectTransform.parent.GetComponent<Image>();
    //    handleImage = uiHandleRectTransform.GetComponent<Image>();

    //    backgroundDefaultColor = backgroundImage.color;
    //    handleDefaultColor = handleImage.color;

    //    toggle.onValueChanged.AddListener(OnSwitch);

    //    if (toggle.isOn)
    //        OnSwitch(true);
    //}

    //public void OnSwitch(bool on)
    //{
    //    //uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition ; // no anim
    //    uiHandleRectTransform.DOAnchorPos(on ? handlePosition * -1 : handlePosition, .2f).SetEase(Ease.InOutBack);
    //    labelRectTransform.DOAnchorPosX(on ? labelPosition.x * -1 : labelPosition.x, .2f).SetEase(Ease.InOutBack);

    //    backgroundImage.color = on ? backgroundActiveColor : backgroundDefaultColor; // no anim
    //                                                                                 //backgroundImage.DOColor (on ? backgroundActiveColor : backgroundDefaultColor, .6f) ;

    //    handleImage.color = on ? handleActiveColor : handleDefaultColor; // no anim
    //                                                                     //handleImage.DOColor (on ? handleActiveColor : handleDefaultColor, .4f) ;

    //    label.text = on ? "On" : "Off";
    //    label.color = on ? Color.white : new Color32(115, 171, 245, 255);

    //}

    //void OnDestroy() => toggle.onValueChanged.RemoveListener(OnSwitch);
}
