/******************************************************************************
** PROGRAMME  ShootMeUp123.cs                                                **
**                                                                           **
** Lieu      : ETML - section informatique                                   **
** Auteur    : Antoine Fabre                                                 **
** Date      : 01.11.2024                                                    **
**                                                                           **
** Modifications                                                             **
**   Auteur  :                                                               **
**   Version :                                                               **
**   Date    :                                                               **
**   Raisons :                                                               **
**                                                                           **
**                                                                           **
******************************************************************************/

/******************************************************************************
** DESCRIPTION                                                               **
** ce programme est un jeu de type space invaders en 2d où il faut tirer sur **     
** les déchêts avec les missiles du vaisseau. pour savoir ce qu'apporte cette**
** page au jeu voir les commentaire ci-dessous.                              **
******************************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SHOOTMEUP123;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOOTMEUP123.Tests
{
    [TestClass()]
    public class BulletEnemiTests
    {
        
        [TestMethod()]
        
        public void MoveBulletEnemiTest()
        {
            // Arrange
            Form1 form1 = new Form1();  //instanciation du form1 pour avoir accès a la picture box de la balle
            int locationybase = 1000;   //variable pour set la location de base de la balle
            BulletEnemi bulletEnnemi = new BulletEnemi(500, locationybase, form1.Ultimate, form1);  //instanciation de la balle

            // Act
            //appele de la methode qui fait avancer la balle 
            bulletEnnemi.MoveBulletEnemi();

            // Assert
            //si la location de base de la balle n'est pas la meme que celle de maintenant le test est réussi
            Assert.AreNotEqual(locationybase, bulletEnnemi.uiElement.Location.Y, "la balle n'a pas bougé");
        }
    }
}