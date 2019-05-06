﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBoardTutorial : Tutorial
{

    public (int, int) lastHighlightLocation;
    public int i =0;

    public override void extraStart()
    {
        instantiateHighlight(0, 1);
        placePiece(board.pawnLightPrefab);
    }


    public override void pickupPiece(ChessPiece piece){

    }

    public override void dropPiece(ChessPiece piece){

    }

    public void setPawns(){

    }

    public void setRooks(){

    }

    public void setKnights(){

    }

    public void setBishops(){

    }

    public void highlightPlacement(){
        if(i==1){
            lastHighlightLocation=(0,1);
            setPawns();
        }
        else if(i==2){
            lastHighlightLocation=(0,0);
            setRooks();
        }
        else if(i==3){
            lastHighlightLocation=(0,1);
            setKnights();
        }
        else if(i==4){
            lastHighlightLocation=(0,2);
            setBishops();
        }
        else if(i==5){
            lastHighlightLocation=(0,3);
        }
        else if(i==6){
            lastHighlightLocation=(0,4);
        }
    }

    private void placePiece(GameObject piece)
    {
        board.instantiatePiece(piece, 4, 3);
    }


}
