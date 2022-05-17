using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine.UI;
using System;
using SirketAdi.ProjeAdi.Utils;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

namespace SirketAdi.ProjeAdi.Core
{
    public class GameplayController : GameState
    {
        //StartNewVariables
        private Vector2 _startTouchPosition;
        private Vector2 _currentPosition;
        private Vector2 _endTouchPosition;
        private bool _stopTouch = false;

        public float swipeRange;
        public float tapRange;
        //////////////
        private bool _enableSlowSwipe = false;
        private bool _isRight = false;

        //FinishNew variables
        private bool _isActive;

    
        [SerializeField] private GameObject hands;
        private bool _mouseTouch = false;
        [SerializeField] private float playerVelocityZ;
        [SerializeField] private GameObject targetPos;
        [NonSerialized] public float money;
        [NonSerialized] public bool finish;
        [SerializeField] private GameObject parentObject;
        

        private void OnEnable()
        {
            Debug.Log("Gameplay State Basladi");
            //button.SetActive(true);
        }

        private void OnDisable()
        {
            Debug.Log("Gameplay State Bitti");
            //button.SetActive(false);
        }
        public void Init()
        {
            _isActive = true;
        }

        public void Disable()
        {
            _isActive = false;
        }
        private void Update()
        { 
            Init();
           if (Input.GetMouseButton(0))
            {
                _mouseTouch = true;
            }

           //PlayerSwipe();
           ObjectTurnAround();
           PlayerMoveForward();
           
           if (finish)
            {
                StateGec();
            }
           if (!_isActive) return;
           if (!_enableSlowSwipe)
           {
               FastSwipe();
           }

        }
        
        //NewSwipeCode1Start
        private void FastSwipe()
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                _startTouchPosition = Input.GetTouch(0).position;
            }

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                _currentPosition = Input.GetTouch(0).position;
                Vector2 distance = _currentPosition - _startTouchPosition;

                if (!_stopTouch)
                {

                    if (distance.x < -swipeRange && _isRight)
                    {
                        LeftToRight();
                        print("Left");
                        _stopTouch = true;
                        _isRight = false;
                    }
                    else if (distance.x > swipeRange && !_isRight)
                    {
                        RightToLeft();
                        print("Right");
                        _stopTouch = true;
                        _isRight = true;
                    }
                    //else if (Distance.y > swipeRange)
                    //{
                    //    print("Up");
                    //    stopTouch = true;
                    //}
                    //else if (Distance.y < -swipeRange)
                    //{
                    //    print("Down");
                    //    stopTouch = true;
                    //}

                }

            }

        
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                _stopTouch = false;

                _endTouchPosition = Input.GetTouch(0).position;

                Vector2 distance = _endTouchPosition - _startTouchPosition;

                if (Mathf.Abs(distance.x) < tapRange && Mathf.Abs(distance.y) < tapRange)
                {
                    //print("Tap");
                }

            }
        }//newSwipeCode1Finish
        
        public void LeftToRight()
        {
            //(-1.93f, 6.97f, -11.77f),
            parentObject.transform.DOLocalJump(new Vector3(-1.93f, 6.97f, -11.77f), 2f, 0, 0.5f);
        }
        
        public void RightToLeft()
        {
            parentObject.transform.DOLocalJump(new Vector3(0.4f, 6.97f, -11.77f), 2f, 0, 0.5f);
        }

        public void changeMode()
        {
            if (!_enableSlowSwipe)
            {
                _enableSlowSwipe = true;
            }
            else
            {
                _enableSlowSwipe = false;
            }

        }

        public void StateGec()
        {
            _controller.CurrentStateFinished();
        }


        public void PlayerMoveForward()
        {
            if (_mouseTouch)
            {
                hands.transform.Translate(Vector3.forward * playerVelocityZ * Time.deltaTime);
            }
        }


        /*Swiping Method 1
        public void PlayerSwipe()
        {
            if (Input.GetMouseButton(0))
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began || Input.GetTouch(0).phase == TouchPhase.Stationary)
                {
                    _firstPos = Input.GetTouch(0).position;
                }
                else if (Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    _secPos = Input.GetTouch(0).position;
                    DoAfterSwipe();
                }

            }
            if (Input.GetMouseButtonUp(0))
            {
                _firstPos = Vector3.zero;
                _secPos = Vector3.zero;
            }
        }

        //Swiping Method 1 Continues
        private void DoAfterSwipe()
        {
            var width = 1080 / Screen.width;
            _distance = (_firstPos.x - _secPos.x) * width;
            // Swiping to the Left
            if (_distance > _treshold && _atRightHand)
            {
                targetPos.transform.DOJump(_leftHandPos, 2, 1, 0.5f, false);
                _atLeftHand = true;
                _atRightHand = false;
                Debug.Log("Swiping To left");
            }

            // Swiping to the Right
            if (_distance < _treshold && _atLeftHand)
            {
                targetPos.transform.DOJump(_rightHandPos, 2, 1, 0.5f, false);
                _atRightHand = true;
                _atLeftHand = false;
                Debug.Log("Swiping To right");
            }
        }*/
        
        //Object Turn Around Endlessly
        private void ObjectTurnAround()
        {
            targetPos.transform.DOLocalRotate(new Vector3(0, 360, 0), 4f, RotateMode.FastBeyond360).SetRelative(true).SetEase(Ease.Linear).SetLoops(-1);
        }

    }
}


