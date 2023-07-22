using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void BolenBul(int ilksayi, int sonsayi)
    {
        for (int i = 2; i <= 5; i++)
        {
            string listetutucu = i + "'e bolunenler: ";
            for (int j = ilksayi; j <= sonsayi; j++)
            {
                if (j % i == 0)
                {
                    listetutucu += j;
                    if (j != sonsayi )
                    {   
                        listetutucu += " - ";
                    }
                }
            }
            listetutucu = listetutucu.TrimEnd(' ', '-');
            print(listetutucu);
        }
    }
    void Start()
    {
        BolenBul(12, 30);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
