using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;

    void Start()
    {
        _text.DOText("The Matrix has you _", 3);
        _text1.DOText(" Knock, knock, Neo.", 10).SetRelative();
        _text2.DOText("403390597_",1,true,ScrambleMode.All);
        _text2.DOColor(Color.red,1);
    }   
}
