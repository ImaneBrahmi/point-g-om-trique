using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointgéomètrique
{
    public class Point
    {
        private double Abscisse;            
        private double Ordonner;  
        public Point()
        {
            //CONSTRUCTEUR Par defaut
        }
        public Point(double x, double y)   //Le constructeur d'initialisation
        {
            Abscisse = x;
            Ordonner = y;
        }
        public double getAbscisse()         //Le getter de l'attribut Abscisse
        {
            return Abscisse;
        }
        public void setAbscisse(double x)   //Le setter de l'attribut Abscisse
        {
            Abscisse = x;
        }
        public double getOrdonner()          //Le getter de l'attribut Ordonne
        {
            return Ordonner;
        }
        public void setOrdonner(double y)    //Le setter de l'attribut Ordonne
        {
            Ordonner = y;
        }
        static public double Sqr(double x) // une fonction qui return la racine d'un nbr donnée 
        {
            return x*x;
        }
        static public double Distance(Point P1, Point P2)  //la methode distance
        {
            return Math.Sqrt(Sqr(P2.Ordonner - P1.Ordonner) + Sqr(P2.Abscisse - P1.Abscisse));
        }
        static public void Egalité(Point P1, Point P2)
        {
            if ((P1.Abscisse == P2.Abscisse) && (P1.Ordonner == P2.Ordonner))
            {
                Console.WriteLine("les 2 points sont egaux");
            }
            else
                Console.WriteLine("les 2 points ne sont pas egaux");
        }
        static public void Translation(Point P1)
        {
            Console.WriteLine("nouveau abssice :");
            P1.Abscisse = int.Parse(Console.ReadLine());
            Console.WriteLine("nouveau ordonnee :");
            P1.Ordonner = int.Parse(Console.ReadLine());
            Console.WriteLine("les nouveaux coordonnees du point sont : Abscisse= " + P1.Abscisse + "Ordonner= " + P1.Ordonner);
        }
        static public void Linéarité(Point P1, Point P2, Point P3)
        {
            double a, b;
            if (P1.Abscisse != P2.Abscisse) //on va montrer d'abord que 2 point sont alignees
            {
                a = (P1.Ordonner - P2.Ordonner) / (P1.Abscisse - P2.Abscisse);
                b = P1.Ordonner + a * P1.Abscisse;   //determiner l'equation de la droite y=ax+b
                if (a * P3.Abscisse + b == P3.Ordonner)//verifier l'appartenence du 3eme point a la droite (P1P2) 
                {
                    Console.WriteLine("les 3 points sont lineaire");
                }
                else
                    Console.WriteLine("les 3 points ne sont pas lineaire");
            }

        }
        static void Main(string[] args)
        {
            Point P1 = new Point(1 ,2);
            Point P2 = new Point(1,-2);
            Point P3 = new Point(1,3);


            Console.WriteLine("Entrez l'abscisse de premier point");
             P1.Abscisse = int.Parse(Console.ReadLine());
             Console.WriteLine("Entrez l'ordonnee de premier point");
             P1.Ordonner = int.Parse(Console.ReadLine());
             Console.WriteLine("Entrez l'abscisse de deuxieme point");
             P2.Abscisse = int.Parse(Console.ReadLine());
             Console.WriteLine("Entrez l'ordonnee de deuxieme point");
             P2.Ordonner = int.Parse(Console.ReadLine());
               Distance(P1,P2);

             //Egalité(P1, P2);
            
             //Translation(P1, P2);
           
             //Linéarité(P1, P2, P3);
        }

        private static void Translation(Point p1, Point p2)
        {
            throw new NotImplementedException();
        }
    }

}

