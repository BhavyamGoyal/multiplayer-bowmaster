﻿using System.Collections;
using System.Collections.Generic;
using Zenject;
using UnityEngine;

namespace PlayerSystem
{
    public interface IPlayerService
    {
        void SetPlayerData(InputData inputData);
    }
}