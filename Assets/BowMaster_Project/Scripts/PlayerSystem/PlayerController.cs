﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerController
    {
        private int playerID;

        private List<PlayerCharacterController> playerCharacterControllerList;
        private PlayerService playerService;

        public PlayerController(int playerID, PlayerService playerService)
        {
            this.playerService = playerService;
            this.playerID = playerID;
            playerCharacterControllerList = new List<PlayerCharacterController>();

            for (int i = 0; i < 3; i++)
            {
                PlayerCharacterController playerCharacterController = new PlayerCharacterController(i, this);
                playerCharacterControllerList.Add(playerCharacterController);
            }
        }

    }
}