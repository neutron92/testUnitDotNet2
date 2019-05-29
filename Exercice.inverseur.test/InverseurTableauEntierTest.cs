using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercice.inverseur;

namespace Exercice.inverseur.test
{
    [TestClass]
    public class InverseurTableauEntierTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void constructeur_TableauEntierNull_souleveArgumentNullException()
        {
            // Arrange
            int[] tableauNull = null;
            // Act
            var resultat = new InverseurTableauEntier(tableauNull);
            // Assert
            // Expected exception ArgumentNullException
        }
        [TestMethod]
        public void inverser_tableauVide_RetourneTableauVide()
        {
            // Arrange
            int[] tableauVide = new int[] { };
            var inverseur = new InverseurTableauEntier(tableauVide);
            int[] resAttendu = new int[] { };
            // Act
            var resultat = inverseur.inverser();
            // Assert
            CollectionAssert.AreEqual(resAttendu, resultat);
        }

        [TestMethod]
        public void inverser_tableauUnElement_RetourneTableauUnElement()
        {
            // Arrange
            int[] tableauVide = new int[1] { 0 };
            var inverseur = new InverseurTableauEntier(tableauVide);
            int[] resAttendu = new int[1] { 0 };
            // Act
            var resultat = inverseur.inverser();
            // Assert
            CollectionAssert.AreEqual(resAttendu, resultat);
        }

        [TestMethod]
        public void inverser_tableauPlusieursElement_RetourneTableauInverse()
        {
            // Arrange
            int[] tableauVide = new int[] { 0,1,2,3,4,5,6 };
            var inverseur = new InverseurTableauEntier(tableauVide);
            int[] resAttendu = new int[] { 6,5,4,3,2,1,0 };
            // Act
            var resultat = inverseur.inverser();
            // Assert
            CollectionAssert.AreEqual(resAttendu, resultat);

        }

        [TestMethod]
        public void inverser_tableauPlusieursElement_RetourneTableauIdentique()
        {
            // Arrange
            int[] tableauVide = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            var inverseur = new InverseurTableauEntier(tableauVide);
            int[] resAttendu = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            // Act
            var inverse = inverseur.inverser();
            var res = new InverseurTableauEntier(inverse).inverser();
            // Assert
            CollectionAssert.AreEqual(resAttendu, res);

        }
    }

}
