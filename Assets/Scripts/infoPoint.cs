using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPoint : MonoBehaviour
{
    Image logo;
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        logo = transform.Find("Logo").GetComponent<Image>();
        txt = transform.Find("Text").GetComponent<Text>();
        StartCoroutine(Waiter(3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Waiter(int sec){
        logo.gameObject.SetActive(true);
        txt.gameObject.SetActive(true);
        yield return new WaitForSeconds(sec);
        logo.gameObject.SetActive(false);
        txt.gameObject.SetActive(false);
    }
    public void TextChange(string text){
        txt.text = text;
        StartCoroutine(Waiter(5));
    }
}
