using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
        public class AllModels
        {
                Dictionary<uint, QuestionParameter> questions = new Dictionary<uint, QuestionParameter>();
                public AllModels()
                {
                        
                        //Intrebari usoare
                        questions.Add(1, new QuestionParameter("Care este capitala Romaniei?", "Iasi", "Bucuresti","Timisoara", "Bucuresti"));
                        questions.Add(2, new QuestionParameter("Cine a fost presedinte pana acum?(RASPUNS MULTIPLU)", "Traian Basescu", "Iohannis", "Ponta", "Traian Basescu", "Iohannis", "", true));
                        questions.Add(3, new QuestionParameter("Cul il cheama pe imparatul roman? (RASPUNS MULTIPLU)", "Tiberius", "Claudius", "Cezar", "Tiberius", "Cezar", "Claudius", true));
                        questions.Add(4, new QuestionParameter("Cati ani are un deceniu?", "35 de ani", "10 ani", "100 de ani", "10 ani"));
                        questions.Add(5, new QuestionParameter("Care este prima planeta de la soare?", "Mercur", "Venus", "Pamant", "Mercur"));
                        questions.Add(6, new QuestionParameter("Care este moneda americana?", "Euro", "Dolar", "Lira", "Dolar"));
                        questions.Add(7, new QuestionParameter("Care este cea mai populata tara?", "SUA", "Republica Populara Chineza", "Japonia", "Republica Populara Chineza"));
                        questions.Add(8, new QuestionParameter("Cine este Mark Zuckerberg?(RASPUNS MULTIPLU)", "Programator", "Co-fondatorul si presedintele Facebook", "Scriitor", "Co-fondatorul si presedintele Facebook", "Programator", "", true));
                        questions.Add(9, new QuestionParameter("Ce faci cand parasuta nu s-a depliat din sac in timpul saltului cu parasuta?(RASPUNS MULTIPLU)", "Largare", "Deschizi rezerva", "Te panichezi", "Largare", "Deschizi rezerva", "", true));
                        questions.Add(10, new QuestionParameter("Ce PlayStation a aparut in 2020?", "PS3", "PS4", "PS5", "PS5"));

                        //Intrebari medii
                        questions.Add(11, new QuestionParameter("Care este cel mai inalt varf din lume?", "Everest", "Aconcagua", "Elbrus", "Everest"));
                        questions.Add(12, new QuestionParameter("Ce aripa e mai buna pentru zbor de distanta?", "Parasuta dreptunghiulara", "Parasuta rotunda", "Parapanta", "Parapanta"));
                        questions.Add(13, new QuestionParameter("Cine este cel mai inalt om din lume?", "Sultan Kosen", "Chandra Bahadur", "Bruce Lee", "Sultan Kosen"));
                        questions.Add(14, new QuestionParameter("Cati copii a avut Stefan cel Mare?", "10 copii", "9 copii", "7 copii", "7 copii"));
                        questions.Add(15, new QuestionParameter("Care este viteza luminii(RASPUNS MULTIPLU)?", "299.729.458 metri pe secunda", "302.106.919.7 metri pe secunda", "299.792 kilometri pe secunda", "299.792 kilometri pe secunda", "299.729.458 metri pe secunda", "", true));
                        questions.Add(16, new QuestionParameter("In ce unitate se masoara unghiurile?", "milimetri patrati", "Metri", "Grade,minute,secunde", "Grade,minute,secunde"));
                        questions.Add(17, new QuestionParameter("Cate grade are un triunghi dreptunghic?", "90", "360", "180", "180"));
                        questions.Add(18, new QuestionParameter("Care este numarul de evanghelisti ai bibliei?", "Doi evanghelisti", "Trei evanghelisti", "Patru evanghelisti", "Patru evanghelisti"));
                        questions.Add(19, new QuestionParameter("Complexitatea structurii de date HASHTABLE pentru a extrage elementul?", "O(1)", "O(n)", "O(logn)", "O(1)"));
                        questions.Add(20, new QuestionParameter("De la ce intaltime sar studentii de la parasutism?(RASPUNS MULTIPLU)", "1200 metri", "3937 picioare", "47244 inchi", "1200 metri", "3937 picioare", "47244 inchi", true));

                        //Intrebari grele
                        questions.Add(21, new QuestionParameter("Cate celule are parafoilul?", "5 celule", "9 celule", "7 celule", "7 celule"));
                        questions.Add(22, new QuestionParameter("Care este acceleratia gravitationala a lunei?", "9,8m/s", "1,6m/s", "2,9m/s", "1,6m/s"));
                        questions.Add(23, new QuestionParameter("Cine a fondat Microsoft?(RASPUNS MULTIPLU)", "Bill Gates", "Paul Allen", "Mark Zuckerberg", "Bill Gates", "Paul Allen", "", true));
                        questions.Add(24, new QuestionParameter("Ce este un infrasunet?", "Un sunet ce nu poate fi auzit de urechea umana", "Sunete ce pot fi auzite de urechea umana", "Vibratii cu frecventa cuprinsa intre 0,001 Hz si 20 Hz", "Vibratii cu frecventa cuprinsa intre 0,001 Hz si 20 Hz"));
                        questions.Add(25, new QuestionParameter("Care este greutatea maxima ce poate fi transportata de un elefant?", "3000 kg", "9000 kg", "1000 kg", "9000 kg"));
                        questions.Add(26, new QuestionParameter("Care este cel mai comun element din scoarta Pamantului?", "Oxigen", "Aluminiu", "Fier", "Oxigen"));
                        questions.Add(27, new QuestionParameter("La ce varsta a murit Adolf Hitler?", "27 de ani", "49 de ani", "56 de ani", "56 de ani"));
                        questions.Add(28, new QuestionParameter("Cat traieste in medie o antilopa?", "10 ani", "15 ani", "20 ani", "15 ani"));
                        questions.Add(29, new QuestionParameter("Cate fire de par are un om in cap?", "100.000 de fire", "120.000 de fire", "150.000 de fire", "100.000 de fire"));
                        questions.Add(30, new QuestionParameter("Care este cel mai adanc lac din lume?", "Lacul Matano", "Lacul Baikal", "Crater Lake", "Lacul Baikal"));
                }
                
                public Dictionary<uint, QuestionParameter> GetInfo()
                {
                        return questions;
                }

        }
        public class QuestionParameter
        {
                private string Question;
                private string Answer1;
                private string Answer2;
                private string Answer3;
                private string RightAnswer1;
                private string RightAnswer2;
                private string RightAnswer3;
                private bool MultipleAnswer;//verific daca are mai multe raspunsuri

                public QuestionParameter(string quest, string a1, string a2, string a3,  string ra1, string ra2 = null, string ra3 = null, bool ma = false)
                {
                        Question = quest;
                        Answer1 = a1;
                        Answer2 = a2;
                        Answer3 = a3;
                        MultipleAnswer = ma;
                        RightAnswer1 = ra1;
                        RightAnswer2 = ra2;
                        RightAnswer3 = ra3;
                }
                public string GetQuestion()
                {
                        return Question;
                }
                public string GetA1()
                {
                        return Answer1;
                }
                public string GetA2()
                {
                        return Answer2;
                }
                public string GetA3()
                {
                        return Answer3;
                }
                public string GetRA1()
                {
                        return RightAnswer1;
                }
                public string GetRA2()
                {
                        return RightAnswer2;
                }
                public string GetRA3()
                {
                        return RightAnswer3;
                }

                public bool CheckMultipleAnswer()
                {
                        return MultipleAnswer;
                }
        }
}
