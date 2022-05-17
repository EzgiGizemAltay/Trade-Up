using System.Collections;
using LevelManagement;
using Sirenix.OdinInspector;
using SirketAdi.ProjeAdi.Core;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

namespace StateMachineTool.StateMachineScrpits.MyScripts
{
    public class ObjectInteraction : MonoBehaviour
    {
        [SerializeField, TabGroup("CollectibleGameObjects")] private GameObject money, coin, fidgetToy, bikini, nflBall, scooter, lipStick, gameboy, guitar, phone, highHeels, monsterCard, rolex, btc, gemRing, sneakers;
        [SerializeField, TabGroup("Others")] private TextMeshPro moneyCounter;
        [FormerlySerializedAs("GameplayController")] [SerializeField, TabGroup("Others")] private GameplayController gameplayController;
        [FormerlySerializedAs("Finishcontroller")] [SerializeField, TabGroup("Others")] private FinishController finishcontroller;
        [SerializeField, TabGroup("CollectibleAnimators")] private Animator fidgetToyAnimator, bikiniAnimator, nflBallAnimator, scooterAnimator, lipStickAnimator, gameboyAnimator, guitarAnimator, phoneAnimator, highHeelsAnimartor, monsterCardAnimator, rolexAnimator, btcAnimator, gemRingAnimator, sneakersAnimator;
        private float _yPos = 0;
        private float _waitTime;


        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("FidgetToy"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(true);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(false);
                sneakers.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "3";
                gameplayController.money = 3;
                fidgetToyAnimator.SetTrigger("Collected");

            }

            if (other.gameObject.CompareTag("Bikini"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(true);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(false);
                sneakers.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "250";
                gameplayController.money = 250;
                bikiniAnimator.SetTrigger("Collected");
            }

            if (other.gameObject.CompareTag("NFLBall"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(true);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(false);
                sneakers.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "100";
                gameplayController.money = 100;
                nflBallAnimator.SetTrigger("Collected");
            }

            if (other.gameObject.CompareTag("Scooter"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(true);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(false);
                sneakers.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "500";
                gameplayController.money = 500;
                scooterAnimator.SetTrigger("Collected");
            }

            if (other.gameObject.CompareTag("LipStick"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(true);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(false);
                sneakers.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "5";
                gameplayController.money = 5;
                lipStickAnimator.SetTrigger("Collected");
            }

            if (other.gameObject.CompareTag("GameBoy"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(true);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(false);
                sneakers.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "25";
                gameplayController.money = 25;
                gameboyAnimator.SetTrigger("Collected");
            }

            if (other.gameObject.CompareTag("Guitar"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(true);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(false);
                sneakers.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "750";
                gameplayController.money = 750;
                guitarAnimator.SetTrigger("Collected");
            }

            if (other.gameObject.CompareTag("Phone"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(true);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(false);
                sneakers.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "2500";
                gameplayController.money = 2500;
                phoneAnimator.SetTrigger("Collected");
            }

            if (other.gameObject.CompareTag("HighHeels"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(true);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(false);
                sneakers.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "10000";
                gameplayController.money = 10000;
                highHeelsAnimartor.SetTrigger("Collected");
            }

            if (other.gameObject.CompareTag("MonsterCard"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(true);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(false);
                sneakers.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "15000";
                gameplayController.money = 15000;
                monsterCardAnimator.SetTrigger("Collected");
            }

            if (other.gameObject.CompareTag("Rolex"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(true);
                btc.SetActive(false);
                gemRing.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "25000";
                gameplayController.money = 25000;
                rolexAnimator.SetTrigger("Collected");
            }

            if (other.gameObject.CompareTag("Btc"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(true);
                gemRing.SetActive(false); 
                sneakers.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "40000";
                gameplayController.money = 40000;
                btcAnimator.SetTrigger("Collected");
            }

            if (other.gameObject.CompareTag("GemRing"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(true);
                sneakers.SetActive(false);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "35000";
                gameplayController.money = 35000;
                btcAnimator.SetTrigger("Collected");
            }
            
            if (other.gameObject.CompareTag("Sneakers"))
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(false);
                sneakers.SetActive(true);
                Destroy(other.gameObject, 0);
                moneyCounter.text = "5000";
                gameplayController.money = 5000;
                sneakersAnimator.SetTrigger("Collected");
            }

            if (other.gameObject.CompareTag("Finish"))
            {
                gameplayController.finish = true;
            }

            if (gameplayController.finish)
            {
                coin.SetActive(false);
                fidgetToy.SetActive(false);
                bikini.SetActive(false);
                nflBall.SetActive(false);
                scooter.SetActive(false);
                lipStick.SetActive(false);
                gameboy.SetActive(false);
                guitar.SetActive(false);
                phone.SetActive(false);
                highHeels.SetActive(false);
                monsterCard.SetActive(false);
                rolex.SetActive(false);
                btc.SetActive(false);
                gemRing.SetActive(false);
                money.SetActive(true);
                var position = money.transform.position;
                var newMoney = Instantiate(money, new Vector3(position.x, position.y+_yPos, position.z), quaternion.identity);
                newMoney.transform.parent = gameObject.transform;
                _yPos += 0.05f;
            }
            
            if (other.gameObject.CompareTag("5") && gameplayController.money == 5)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("50") && gameplayController.money == 50)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("250") && gameplayController.money == 250)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("500") && gameplayController.money == 500)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("750") && gameplayController.money == 750)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("2500") && gameplayController.money == 2500)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("5000") && gameplayController.money == 5000)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("10000") && gameplayController.money == 10000)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("12500") && gameplayController.money == 12500)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("15000") && gameplayController.money == 15000)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("20000") && gameplayController.money == 20000)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("22500") && gameplayController.money == 22500)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("25000") && gameplayController.money == 25000)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("30000") && gameplayController.money == 30000)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("35000") && gameplayController.money == 35000)
            {
                Ending();
            }

            else if (other.gameObject.CompareTag("40000") && gameplayController.money == 40000)
            {
                Ending();
            }
        }
        public void Ending()
        {
            finishcontroller.stop = true;
            StartCoroutine(WaitAndWin(2));
        }

        IEnumerator WaitAndWin(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            WinScreen.Open();
        }
        
        
    }
}


