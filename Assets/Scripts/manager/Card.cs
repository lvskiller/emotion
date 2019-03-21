﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {

    public class Card_
    {
          public GameObject image;
          public string name;
          public int[] types;
          public int[] counts;
    }
    
    List<List<Card_>> decks=new List<List<Card_>> ();
    List<List<Card_>> handCard=new List<List<Card_>> ();
    public void createCard(int type,GameObject image,string name, int[] types,int[] counts)
    {
            Card_ temp =new Card_();
            temp.name = name;
            temp.image = image;
            temp.types = types;
            temp.counts = counts;
            decks[type].Add(temp);
        
    }

    public Card_ useCard(int type, int x)
    {
            Card_ temp =decks[type][x];
            destroyCard(type, x);
            return temp;
      
    }

    public void destroyCard(int type, int x)
    {
        decks[type].Remove(decks[type][x]);
    }
    public void createDeck(int type)
    {
        if (type == 0)
        {
            List<Card_> deck=new List<Card_>();
            decks.Add(deck);
        }
        else
        {
            List<Card_> deck=new List<Card_>();
            decks.Add(deck);
        }
    }

    public void destroyDeck(int type)
    {
            decks.Remove(decks[type]);
    }

    public void washDeck(int type)
    {
        
    }
}
