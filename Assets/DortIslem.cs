using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DortIslem : MonoBehaviour
{
    public Text birincisayý, ikincisayý, islem, cevap, sonuc;
    public InputField sonucInput;
    int sayý1, sayý2, islemÝsareti;
    int islemSonucu;
    int maxSayý;
    void Start()
    {
        YeniSoru();
    }
    void Update()
    {

    }
    public void CevapKontrol()
    {
        if (int.Parse(cevap.text) == islemSonucu)
        {
            sonuc.text = "DOÐRU";
        }
        else
            sonuc.text = "YANLIÞ";
    }

    public void YeniSoru()
    {
        sonuc.text = " ";
        sonucInput.text = " ";
        maxSayý = maxSayý + 2;
        sayý1 = Random.Range(1, maxSayý);
        sayý2 = Random.Range(1, maxSayý);
        islemÝsareti = Random.Range(1, 5);
        switch (islemÝsareti)
        {
            case 1:
                islem.text = "+";
                islemSonucu = sayý1 + sayý2;
                break;
            case 2:
                islem.text = "-";
                islemSonucu = sayý1 - sayý2;
                break;
            case 3:
                islem.text = "*";
                islemSonucu = sayý1 * sayý2;
                break;
            case 4:
                islem.text = "/";
                islemSonucu = sayý1 / sayý2;
                break;

        }
        birincisayý.text = sayý1 + "";
        ikincisayý.text = sayý2 + "";

    }
}