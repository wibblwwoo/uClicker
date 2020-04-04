﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace uClicker
{
    [CreateAssetMenu(menuName = "uClicker/Currency")]
    public class Currency : ClickerComponent
    {
        public float PercentIncr = 0.15f;
    }
}