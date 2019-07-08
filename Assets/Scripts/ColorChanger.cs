using UnityEngine;
using System.Collections;

public class ColorChanger : MonoBehaviour
{
    public Material material;

    int state = 0;
    float r=0, g=1, b=0;

    public void Start()
    {
        material.SetColor("_Color", new Color(r,g,b));
        StartCoroutine(enumerator());
    }

    public IEnumerator enumerator()
    {
        for (; ; )
        {
            if (state == 0)
            {
                b += 0.05f;
                if (b >= 1)
                {
                    state++;
                }
            }
            else if (state == 1)
            {
                g -= 0.05f;
                if (g <= 0)
                {
                    state++;
                }
            }
            else if (state == 2)
            {
                r += 0.05f;
                if (r >=1)
                {
                    state++;
                }
            }
            else if (state == 3)
            {
                b -= 0.05f;
                if (b<=0)
                {
                    state++;
                }
            }
            else if (state == 4)
            {
                g += 0.05f;
                if (g>=1)
                {
                    state++;
                }
            }
            else if (state == 5)
            {
                r -= 0.05f;
                if (r<=0)
                {
                    state=0;
                }
            }
            material.SetColor("_Color", new Color(r, g, b));
            yield return new WaitForSeconds(0.01f);
        }
    }

}
