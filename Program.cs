using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setul3
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth - 40, Console.LargestWindowHeight - 20);
            Console.WriteLine(@"1.  Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
2.  Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 
3.  Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 
4.  Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
5.  Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 
6.  Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
7.  Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
8.  Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
9.  Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
10. Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. 
11. Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 
12. Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
13. Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 
14. Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 
15. Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 
16. Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
17. Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   
18. Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. 
19. Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 
20. Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. 
21. Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 
22. Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. 
23. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. 
24. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
25. (Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 
26. Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 
27. Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. 
28. Quicksort. Sortati un vector folosind metoda QuickSort. 
29. MergeSort. Sortati un vector folosind metoda MergeSort.
30. Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 
31. (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara).");
            Console.WriteLine("Numarul problemei pe care vrei sa o rezolvi: ");
            int nrProblema = int.Parse(Console.ReadLine());
            switch (nrProblema)
            {
                case 1: Console.Clear(); Problema1(); break;
                case 2: Console.Clear(); Problema2(); break;
                case 3: Console.Clear(); Problema3(); break;
                case 4: Console.Clear(); Problema4(); break;
                case 5: Console.Clear(); Problema5(); break;
                case 6: Console.Clear(); Problema6(); break;
                case 7: Console.Clear(); Problema7(); break;
                case 8: Console.Clear(); Problema8(); break;
                case 9: Console.Clear(); Problema9(); break;
                case 10: Console.Clear(); Problema10(); break;
                case 11: Console.Clear(); Problema11(); break;
                case 12: Console.Clear(); Problema12(); break;
                case 13: Console.Clear(); Problema13(); break;
                case 14: Console.Clear(); Problema14(); break;
                case 15: Console.Clear(); Problema15(); break;
                case 16: Console.Clear(); Problema16(); break;
                case 17: Console.Clear(); Problema17(); break;
                case 18: Console.Clear(); Problema18(); break;
                case 19: Console.Clear(); Problema19(); break;
                case 20: Console.Clear(); Problema20(); break;
                case 21: Console.Clear(); Problema21(); break;
                case 22: Console.Clear(); Problema22(); break;
                case 23: Console.Clear(); Problema23(); break;
                case 24: Console.Clear(); Problema24(); break;
                case 25: Console.Clear(); Problema25(); break;
                case 26: Console.Clear(); Problema26(); break;
                case 27: Console.Clear(); Problema27(); break;
                case 28: Console.Clear(); Problema28(); break;
                case 29: Console.Clear(); Problema29(); break;
                case 30: Console.Clear(); Problema30(); break;
                case 31: Console.Clear(); Problema31(); break;
                default:
                    break;
            }
        }

        private static void Problema1()
        {
            Console.WriteLine("Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int sum = 0;
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                sum += v[i];
            }
            Console.WriteLine($"Suma elementelor vectorului este {sum}");
        }

        private static void Problema2()
        {
            Console.WriteLine("Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int poz = -1;
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if(v[i]==k && poz == -1)
                    poz = i;
            }
            if(poz == -1)
                Console.WriteLine($"Numarul {k} nu apare in vector");
            else
                Console.WriteLine($"Numarul {k} se afla pe pozitia {poz}");
        }

        private static void Problema3()
        {
            Console.WriteLine("Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int min = int.MaxValue, max = int.MinValue;
            int pozmin = -1, pozmax = -1;
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] < min)
                {
                    min = v[i];
                    pozmin = i;
                }
                if (v[i] > max)
                {
                    max = v[i];
                    pozmax = i;
                }
            }
                Console.WriteLine($"Numarul minim se afla pe pozitia {pozmin}" +
                    $", iar numarul maxim pe pozitia {pozmax}");
        }

        private static void Problema4()
        {
            Console.WriteLine("Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int min = int.MaxValue, max = int.MinValue;
            int aparitiiMin = 0, aparitiiMax = 0;
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] == min)
                    aparitiiMin++;
                else if (v[i] == max)
                    aparitiiMax++;
                else if (v[i] < min)
                {
                    min = v[i];
                    aparitiiMin = 1;
                }
                else if (v[i] > max)
                {
                    max = v[i];
                    aparitiiMax = 1;
                }
            }
            Console.WriteLine($"Numarul minim apare de {aparitiiMin} ori" +
                $", iar numarul maxim apare de {aparitiiMax} ori");
        }

        private static void Problema5()
        {
            Console.WriteLine("Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("e: ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n+1];
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i <= n; i++)
            {
                if (i == k)
                    v[i++] = e;
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= n; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        private static void Problema6()
        {
            Console.WriteLine("Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = k; i < n-1; i++)
            {
                v[i] = v[i + 1];
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        private static void Problema7()
        {
            Console.WriteLine("Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                v[n-i-1] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        private static void Problema8()
        {
            Console.WriteLine("Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                if(i==0)
                    v[n-1] = int.Parse(Console.ReadLine());
                else
                    v[i-1] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        private static void Problema9()
        {
            Console.WriteLine("Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());
            if (k > n)
                k %= n;
            int[] v = new int[n];
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                if (i < k)
                    v[n - k + i] = int.Parse(Console.ReadLine());
                else
                    v[i - k] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }
        
        private static void Problema10()
        {
            Console.WriteLine("Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int poz = -1,st=0,dr=n-1;
            while(st < dr)
            {
                int mij = (st + dr) / 2;
                if (v[mij] == k)
                {
                    poz = mij;
                    break;
                }
                else if (v[mij] > k)
                    dr = mij - 1;
                else st = dr + 1;
            }
            if (poz == -1)
                Console.WriteLine($"Elementul {k} nu se afla in vector");
            else
                Console.WriteLine($"Elementul {k} se afla in vector pe pozitia {poz}");
        }

        private static void Problema11()
        {
            Console.WriteLine("Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n+1];
            if(n>=2)
                Console.Write("2 ");
            for (int i = 3; i <= n-1; i+=2)
            {
                if (v[i] == 0)
                {
                    Console.Write($"{i} ");
                    for (int j = 2 * i; j <= n; j += i)
                    {
                        v[j] = 1;
                    }
                }
                else continue;
            }
        }

        private static void Problema12()
        {
            Console.WriteLine("Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n+1];
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n-1; i++)
            {
                int indexMin = i;
                for (int j = i+1; j < n; j++)
                    if (v[j] < v[indexMin])
                        indexMin = j;
                int temp = v[indexMin];
                v[indexMin] = v[i];
                v[i] = temp;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }

        private static void Problema13()
        {
            Console.WriteLine("Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < n; i++)
            {
                int nr = v[i];
                int j = i - 1;
                while(j>=0 && v[j] > nr)
                {
                    v[j + 1] = v[j];
                    j--;
                }
                v[j + 1] = nr;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }

        private static void Problema14()
        {
            Console.WriteLine("Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului).");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int nr_zero = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] == 0)
                {
                    nr_zero++;
                    for (int j = i; j < n - 1; j++)
                        v[j] = v[j + 1];
                }
            }
            for (int i = n - nr_zero; i < n; i++)
                v[i] = 0;
                for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }

        private static void Problema15()
        {
            Console.WriteLine("Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Citeste vectorul:");
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!v.Contains(num))
                    v[i] = num;
                else
                {
                    i--;
                    n--;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }

        private static void Problema16()
        {
            Console.WriteLine("Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema17()
        {
            Console.WriteLine("Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema18()
        {
            Console.WriteLine("Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema19()
        {
            Console.WriteLine("Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar).");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema20()
        {
            Console.WriteLine("Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema21()
        {
            Console.WriteLine("Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar).");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema22()
        {
            Console.WriteLine("Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema23()
        {
            Console.WriteLine("Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema24()
        {
            Console.WriteLine("Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema25()
        {
            Console.WriteLine("(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema26()
        {
            Console.WriteLine("Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema27()
        {
            Console.WriteLine("Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema28()
        {
            Console.WriteLine("Quicksort. Sortati un vector folosind metoda QuickSort.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema29()
        {
            Console.WriteLine("MergeSort. Sortati un vector folosind metoda MergeSort.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema30()
        {
            Console.WriteLine("Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

        private static void Problema31()
        {
            Console.WriteLine("(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara).");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
        }

    }
}
