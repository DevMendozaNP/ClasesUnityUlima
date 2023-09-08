using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonCard
{
    public string pokemonName;
    public bool isShown;

    public PokemonCard(string name)
    {
        pokemonName = name;
        isShown = false;
    }
}

public class GameManager : MonoBehaviour
{
    private List <PokemonCard> pokemonCardList;
    private PokemonCard chosenCard = null;
    private Cards card1;
    private Cards card2;

    private void Start()
    {
        pokemonCardList = new List<PokemonCard>();

        PokemonCard card1 = new PokemonCard("psyduck");
        PokemonCard card2 = new PokemonCard("charmander");
        PokemonCard card3 = new PokemonCard("jigglypuff");
        PokemonCard card4 = new PokemonCard("snorlax");
        PokemonCard card5 = new PokemonCard("charmander");
        PokemonCard card6 = new PokemonCard("pidgey");
        PokemonCard card7 = new PokemonCard("pikachu");
        PokemonCard card8 = new PokemonCard("bulbasaur");
        PokemonCard card9 = new PokemonCard("squirtle");
        PokemonCard card10 = new PokemonCard("jigglypuff");
        PokemonCard card11 = new PokemonCard("pidgey");
        PokemonCard card12 = new PokemonCard("snorlax");
        PokemonCard card13 = new PokemonCard("squirtle");
        PokemonCard card14 = new PokemonCard("pikachu");
        PokemonCard card15 = new PokemonCard("psyduck");
        PokemonCard card16 = new PokemonCard("bulbasaur");

        pokemonCardList.Add(card1);
        pokemonCardList.Add(card2);
        pokemonCardList.Add(card3);
        pokemonCardList.Add(card4);
        pokemonCardList.Add(card5);
        pokemonCardList.Add(card6);
        pokemonCardList.Add(card7);
        pokemonCardList.Add(card8);
        pokemonCardList.Add(card9);
        pokemonCardList.Add(card10);
        pokemonCardList.Add(card11);
        pokemonCardList.Add(card12);
        pokemonCardList.Add(card13);
        pokemonCardList.Add(card14);
        pokemonCardList.Add(card15);
        pokemonCardList.Add(card16);

    }

    public void PlayCard(int position, Cards card)
    {
        if (chosenCard == null)
        {
            //aún no se han elegido cartas al inicio del turno.//
            chosenCard = pokemonCardList[position];
            card1 = card;
        }else
        {
            //Si ya se tiene una carta abierta, validar si es que hay match.//
            card2 = card;
            PokemonCard secondCard = pokemonCardList[position];

            //verificar si hay match.
            if (chosenCard.pokemonName == secondCard.pokemonName)
            {
                //hay match.//
                chosenCard.isShown = true;
                secondCard.isShown = true;
            }else
            {
                Invoke("CloseCards",2f);
            }
            chosenCard = null;
        }
    }

    public void CloseCards()
    {
        card1.CloseCard();
        card2.CloseCard();
    }
}