using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DortIslem : MonoBehaviour
{
    public Text birincisay�, ikincisay�, islem, cevap, sonuc;
    public InputField sonucInput;
    int say�1, say�2, islem�sareti;
    int islemSonucu;
    int maxSay�;
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
            sonuc.text = "DO�RU";
        }
        else
            sonuc.text = "YANLI�";
    }

    public void YeniSoru()
    {
        sonuc.text = " ";
        sonucInput.text = " ";
        maxSay� = maxSay� + 2;
        say�1 = Random.Range(1, maxSay�);
        say�2 = Random.Range(1, maxSay�);
        islem�sareti = Random.Range(1, 5);
        switch (islem�sareti)
        {
            case 1:
                islem.text = "+";
                islemSonucu = say�1 + say�2;
                break;
            case 2:
                islem.text = "-";
                islemSonucu = say�1 - say�2;
                break;
            case 3:
                islem.text = "*";
                islemSonucu = say�1 * say�2;
                break;
            case 4:
                islem.text = "/";
                islemSonucu = say�1 / say�2;
                break;

        }
        birincisay�.text = say�1 + "";
        ikincisay�.text = say�2 + "";

    }
}