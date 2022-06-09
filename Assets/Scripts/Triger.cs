using UnityEngine;
using UnityEngine.Events;

public class Triger : MonoBehaviour
{
    [Header("Main Settings")]
    public string TagObject;


    public UnityEvent TriggerEventEnter;
    public UnityEvent TriggerEventExit;
    public UnityEvent TriggerEventStay;



    public void InvokeTrigger()
    {

        TriggerEventEnter?.Invoke();
        TriggerEventExit?.Invoke();
        TriggerEventStay?.Invoke();




    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == TagObject)
        {
            print("nyentuh");


            TriggerEventEnter?.Invoke();



        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == TagObject)
        {
            print("keluar");


            TriggerEventExit?.Invoke();



        }
    }



    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == TagObject)
        {
            print("stay");


            TriggerEventStay?.Invoke();



        }




    }







    private void Update()
    {

    }




}
