using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CU
{
    public class CharacterManager : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }

}
