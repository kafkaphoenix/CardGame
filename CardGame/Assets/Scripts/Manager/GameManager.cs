﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cards.GameStates;

namespace Cards
{
    public class GameManager : MonoBehaviour
    {
        public State currentState;
        public PlayerHolder currentPlayer;
        public GameObject cardPrefab;

        private void Start()
        {
            Settings.gameManager = this;
            CreateStartingCards();

        }

        void CreateStartingCards()
        {
            ResourcesManager rm = Settings.GetResourcesManager();

            for (int i = 0; i < currentPlayer.startingCards.Length; i++)
            {
                GameObject go = Instantiate(cardPrefab) as GameObject;
                CardViz v = go.GetComponent<CardViz>();
                v.LoadCard(rm.GetCardInstance(currentPlayer.startingCards[i]));
                CardInstance inst = go.GetComponent<CardInstance>();
                inst.currentLogic = currentPlayer.handLogic;
                Settings.SetParentForCard(go.transform, currentPlayer.handGrid.value);
            }
        }

        private void Update()
        {
            currentState.Tick(Time.deltaTime);
        }

        public void SetState(State state)
        {
            currentState = state;
        }
    }

}
