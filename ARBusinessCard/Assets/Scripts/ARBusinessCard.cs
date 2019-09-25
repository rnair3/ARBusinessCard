using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARBusinessCard : MonoBehaviour, IVirtualButtonEventHandler
{
    [SerializeField] GameObject developerVB, gamerVB, dancerVB;

    VirtualButtonBehaviour[] vrb;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "DeveloperVB")
        {
            developerVB.SetActive(true);
            gamerVB.SetActive(false);
            dancerVB.SetActive(false);
        }


        else if (vb.VirtualButtonName == "GamerVB")
        {
            developerVB.SetActive(false);
            gamerVB.SetActive(true);
            dancerVB.SetActive(false);
        }


        else if (vb.VirtualButtonName == "DancerVB")
        {
            developerVB.SetActive(false);
            gamerVB.SetActive(false);
            dancerVB.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + " not supported");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        developerVB.SetActive(false);
        gamerVB.SetActive(false);
        dancerVB.SetActive(false);

        vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
