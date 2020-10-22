using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputActionSetup
{
    public static MyInputActions MIA;

    public static void Init()
    {
        MIA = new MyInputActions();
        
        MIA.Enable();
    }

}
