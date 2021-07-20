using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum State { Man = 1, Woman = -1, Gender = 0}

//public enum President {Victor = 71, Petro = 55, Volodymir = 43 }



public class MyEnym : MonoBehaviour
{
    //State state = State.Man;
    //private void Awake()
    //{
    //    print(state);
    //    state = State.Gender;
    //    int i = (int)state;
    //    print(i);
    //}

    //private void Start()
    //{
    //    print(state);
    //    if (state == State.Man)
    //    {
    //        print("Муж");
    //    }
    //    else if (state == State.Woman)
    //    {
    //        print("Жен");
    //    }
    //    else if (state == State.Gender)
    //    {
    //        print("Ген");
    //    }
    //}              

    //private void Start()
    //{
    //    int Victor = 71;
    //    int Petro = 55;
    //    int Volodymir = 43;
    //    if (Victor > 60) ;
    //    if (Petro > 60) ;
    //    if (Volodymir > 60) ;
    //    {
    //        print("Result1");
    //    }
    //   else
    //    {
    //        print("Result2");
    //    }
    //    else
    //    {
    //        print("Result3");
    //    }
    //}


    enum Presidents { Pytin = 65, Obama = 61, Tramp = 49 } // обьявление перечисления(создание)

    Presidents myPresident = Presidents.Tramp; // Создание экземпляра перечисления И присвоили значения
    Presidents russionPresident = Presidents.Pytin; //// Создание еще одного экземпляра перечисления

    private void Awake()
    {
        if (myPresident == Presidents.Pytin) //сравнение по состоянию(имени)
        {
            print("Тикай");
        }

        if ((int)myPresident >= 60)  // сравниваем значение
        {
            print("Опытный лидер");
        }
        else
        {
            print("НЕ Опытный лидер");
        }

    }
}
