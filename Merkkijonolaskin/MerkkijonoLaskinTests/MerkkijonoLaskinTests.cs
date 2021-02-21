using System;
using MerkkijonoLaskinKonsoli;
using NUnit.Framework;

namespace MerkkijonoLaskinTests
{
    //  Luo ohjelma alla mainittujen vaatimuksiin perustuen siten,
    //  että sinulla on vähintään yksi testi jokaiselle vaatimukselle.
    //  Kun olet kirjoittanut testin, voit vielä tehdä ohjelmasta konsoliohjelman.


    //      [] Tyhjä merkkinojo palauttaa nollan.
    //      [] Yksi numero, laskin palauttaa annetun numeron arvon..
    //      [] Kaksi numeroa, pilkulla erotettuna, palauttaa lukujen summan.
    //      [] Toteuta ominaisuus, että numeroita voidaan antaa pilkulla erotettuna rajoittamaton määrä ja laskin palauttaa lukujen summan.
    //      [] Toteuta ominaisuus, että pilkkujen tilalla voidaan käyttää newline merkintää lukujen erottimena pilkkujen sijaan. (newline = \n)
    //          Esimerkiksi arvo "1\n2,3" palauttaisi summan 6.
    //          Ei tarvitse tukea muotoa, jossa erottimet seuraavat toisiaan.Esimerkiksi "1,\n". Voidaan olettaa, ettei tällaisia syötteitä anneta.
    //      [] Negatiivinen luku, pienempi kuin nolla, aiheuttaa virheen. (Exception)
    //      [] Luvut, jotka ovat yli 1000, ei huomioida yhteenlaskussa.
    public class MerkkijonolaskinTests
    {
        [SetUp]
        public void Setup()
        {
        }

        // [] Tyhjä merkkinojo palauttaa nollan.
        [Test]
        public void TyhjaMerkkijonoPalauttaaNollan()
        {
            // Arrange
            MerkkijonoLaskin laskin = new MerkkijonoLaskin();

            // Act
            int vastaus = laskin.Laske("");

            // Assert
            Assert.AreEqual(0, vastaus);
        }

        // [] Yksi numero, laskin palauttaa annetun numeron arvon.
        [Test]
        public void YksiNumeroJolloinLaskinPalauttaaAnnetunNumeronArvon()
        {
            // Arrange
            MerkkijonoLaskin laskin = new MerkkijonoLaskin();

            // Act
            int vastaus = laskin.Laske("1");

            // Assert
            Assert.AreEqual(1, vastaus);
        }

        // [] Kaksi numeroa, pilkulla erotettuna, palauttaa lukujen summan.
        [Test]
        public void KaksiNumeroaPilkullaErotettunaPalauttaaLukujenSumman()
        {
            // Arrange
            MerkkijonoLaskin laskin = new MerkkijonoLaskin();

            // Act
            int vastaus = laskin.Laske("2,5");

            // Assert
            Assert.AreEqual(7, vastaus);
        }

        // [] Negatiivinen luku, pienempi kuin nolla, aiheuttaa virheen. (Exception)
        [Test]
        public void NegatiivinenLukuPienempiKuinNollaAiheuttaaVirheen()
        {
            // Arrange
            MerkkijonoLaskin laskin = new MerkkijonoLaskin();
            // Act
            // Assert
            Assert.Throws<MerkkijonoLaskinException>(() => {
                laskin.Laske("2,-2");
            });
        }
    }
}