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
    public class BulletUltimateTests
    {
        [TestMethod()]
        public void BulletShootTest()
        {
            // Arrange
            Form1 form1 = new Form1();  //on créer le form1 pour avoir accès a la picturebox1
            int locationy = form1.pictureBox1.Location.Y;   //variable pour savoir où est la picture box sur l'axe des Y
            int locationx = form1.pictureBox1.Location.X;   //variable pour savoir où est la picture box sur l'axe des X  
            BulletUltimate bulletUltimate = new BulletUltimate(locationx,locationy,form1.Ultimate,form1);   //instanciation de la classe bullet

            // Act
            bulletUltimate.BulletShoot(locationx,locationy);    //appele de la methode qui va faire apparaitre la balle au bon endroit

            // Assert
            //si la balle est bien a la meme position que le vaisseau au niveau des X le test est réussi
            Assert.AreEqual(bulletUltimate.uiElement.Location.X , form1.pictureBox1.Location.X, "la balle n'est pas apparu sous le vaisseau");
        }
    }
}