using MandotaryAssignment01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MandotaryAssignment01.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();

        static Repository()
        {
            Book b1 = new Book("Georg Martin", "With a Little Help from My Friends: The Making of Sgt. Pepper", 19.95M, 1995);
            Book b2 = new Book("Mr Smith", "Californication", 59.95M, 2001);
            Book b3 = new Book("Magnus", "The life rules", 39.95M, 2013);
            b1.ISBN = "978-3-16-148410-0";
            b2.ISBN = "456-3-16-148410-0";
            b3.ISBN = "678-3-16-148410-0";
            Products.Add(b1);
            Products.Add(b2);
            Products.Add(b3);
            Products.Add(new Movie("Run in 60", 60.50M, "https://picsum.photos/200/300", "Steven"));
            Products.Add(new Movie("The Street", 154.50M, "https://picsum.photos/200/300", "Mozart"));
            Products.Add(new Movie("Forrest Gump", 99.50M, "https://picsum.photos/200/300", "Someone elese"));

            MusicCD cd1 = new MusicCD("Taylor Swift", "The Man", 6.95M, 2019);
            cd1.Label = "CG Records";
            cd1.AddTrack(new Track("The candle", new TimeSpan(0, 3, 35)));
            cd1.AddTrack(new Track("The avocado", new TimeSpan(0, 2, 25)));
            cd1.AddTrack(new Track("With tuna", new TimeSpan(0, 5, 25)));
            MusicCD cd2 = new MusicCD("Lady Gaga", "The wrecking ball", 6.95M, 2019);
            cd2.Label = "Universal Music Group";
            cd2.AddTrack(new Track("Lights goes off", new TimeSpan(0, 1, 35)));
            cd2.AddTrack(new Track("OnePlus", new TimeSpan(0, 2, 35)));
            cd2.AddTrack(new Track("Cucumber", new TimeSpan(0, 4, 25)));
            Products.Add(cd1);
            Products.Add(cd2);

            Customer c1 = new Customer(11, "Mohamed", "Jensen", "Kilen 62", "9510", "Arden");
            Customer c2 = new Customer(22, "Laurits", "Petersen", "Ribelandevej 50", "6372", "Bylderup-Bov");
            Customer c3 = new Customer(33, "Mads", "Madsen", "Nyhavn 59", "2880", "Bagsværd ");
            Customer c4 = new Customer(44, "Cecilie S.", "Bruun", "Gammel Byvej 93", "4681", "Herfølge");

            Invoice i1 = new Invoice(1, new DateTime(), c1);
            Invoice i2 = new Invoice(2, new DateTime(), c2);
            Invoice i3 = new Invoice(3, new DateTime(), c3);
            Invoice i4 = new Invoice(4, new DateTime(), c4);

            i1.AddOrderItem(Products[2], 1).AddOrderItem(Products[0], 1);
            i2.AddOrderItem(Products[3], 1).AddOrderItem(Products[4], 1);

            Invoices.Add(i1);
            Invoices.Add(i2);
            Invoices.Add(i3);
            Invoices.Add(i4);
        }
    }
}
