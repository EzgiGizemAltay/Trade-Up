using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using DG.Tweening;
using SirketAdi.ProjeAdi.Utils;
using UnityEngine.Serialization;

namespace SirketAdi.ProjeAdi.Core
{

    public class FinishController : GameState
    {
        [SerializeField] private GameObject hands;
        [NonSerialized] public bool stop = false;
        [SerializeField] private float playerVelocityZ;
        private float _distance, _distanceShouldPlayerGo;
        [SerializeField] private GameObject cubeFirst, cubeSecond;
        [FormerlySerializedAs("GamePlayController")] [SerializeField] private GameplayController gameplayController;
        
        private void OnEnable()
        {
            Debug.Log("Finish State Basladi");
            //button.SetActive(true);
        }

        private void OnDisable()
        {
            Debug.Log("Finish State Bitti");
            //button.SetActive(false);
        }

        private void Update()
        {
            FinishMove();
        }

        public void StateGec()
        {
            _controller.CurrentStateFinished();
        }
        
        public void FinishMove()
        {
            if (!stop)
            {
                hands.transform.Translate(Vector3.forward * 4 * playerVelocityZ * Time.deltaTime);
            }
            
            /*var calculationSpeed = 2 * playerVelocityZ;
            _distance = (cubeSecond.transform.position - cubeFirst.transform.position).magnitude;
            _distanceShouldPlayerGo = (gamePlayController.money * _distance) / 40000 * Time.deltaTime;
            var necessaryTime = _distanceShouldPlayerGo / calculationSpeed;
            var reductionMagnitude = _distanceShouldPlayerGo / necessaryTime;
            gamePlayController.money -= reductionMagnitude * Time.deltaTime; //TODO

            if (gamePlayController.money <= 0)
            {
                stop = true;
            }*/
        }
        
        private void OnTriggerEnter(Collider other)
        {
            
        }

    }

}