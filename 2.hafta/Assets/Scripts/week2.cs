using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dev2 : MonoBehaviour
{

    void BolenBul(int ilksayi, int sonsayi)
    {
        for (int i = 2; i <= 5; i++)
        {
            print(i + "'e bolunenler:");
            for (int j = ilksayi;j <= sonsayi;j++) 
            {
                if (j / i == 0)
                {
                    print(j);
                    if (j != sonsayi)
                    {
                        print(" - ");
                    }
                }
            }
        }
    }
    void Start()
    {
        BolenBul(1,10);
    }

    void Update()
    {
        
    }
}
