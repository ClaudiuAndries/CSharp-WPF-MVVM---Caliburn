using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
        public class SecondViewModel : Screen
        {
                public string _fullName;
                public string _DifficultTest;

                //Random calculate
                Random randomNumber = new Random();

                uint q1, q2, q3, q4, q5;
                int dificultTest = 0;
                public AllModels questions;
                public SecondViewModel(string args)
                {
                        CalculateRandomQuestions();

                        _fullName = args;
                        NotifyOfPropertyChange(() => FullName);
                        questions = new AllModels();
                        //Calcul Difficult test
                        if(dificultTest <=-2)
                        {
                                _DifficultTest = "Dificultate: usoara";
                        }
                        else if (dificultTest >= -1 && dificultTest <= 1)
                        {
                                _DifficultTest = "Dificultate: medie";
                        }
                        else
                        {
                                _DifficultTest = "Dificultate: grea";
                        }

                        NotifyOfPropertyChange(() => DifficultTest);
                        //Load First set
                        _FirstQuestion = questions.GetInfo()[q1].GetQuestion();
                        NotifyOfPropertyChange(() => FirstQuestion);

                        _ContentBoxFirstSet1 = questions.GetInfo()[q1].GetA1();
                        _ContentBoxFirstSet2 = questions.GetInfo()[q1].GetA2();
                        _ContentBoxFirstSet3 = questions.GetInfo()[q1].GetA3();

                        NotifyOfPropertyChange(() => ContentBoxFirstSet1);
                        NotifyOfPropertyChange(() => ContentBoxFirstSet2);
                        NotifyOfPropertyChange(() => ContentBoxFirstSet3);

                        //Load Second Set
                        _SecondQuestion = questions.GetInfo()[q2].GetQuestion();
                        NotifyOfPropertyChange(() => SecondQuestion);

                        _ContentBoxSecondSet1 = questions.GetInfo()[q2].GetA1();
                        _ContentBoxSecondSet2 = questions.GetInfo()[q2].GetA2();
                        _ContentBoxSecondSet3 = questions.GetInfo()[q2].GetA3();

                        NotifyOfPropertyChange(() => ContentBoxSecondSet1);
                        NotifyOfPropertyChange(() => ContentBoxSecondSet2);
                        NotifyOfPropertyChange(() => ContentBoxSecondSet3);


                        //Load Third Set
                        _ThirdQuestion = questions.GetInfo()[q3].GetQuestion();
                        NotifyOfPropertyChange(() => ThirdQuestion);

                        _ContentBoxThirdSet1 = questions.GetInfo()[q3].GetA1();
                        _ContentBoxThirdSet2 = questions.GetInfo()[q3].GetA2();
                        _ContentBoxThirdSet3 = questions.GetInfo()[q3].GetA3();


                        NotifyOfPropertyChange(() => ContentBoxThirdSet1);
                        NotifyOfPropertyChange(() => ContentBoxThirdSet2);
                        NotifyOfPropertyChange(() => ContentBoxThirdSet3);

                        //Load Fourth Set
                        _FourthQuestion = questions.GetInfo()[q4].GetQuestion();
                        NotifyOfPropertyChange(() => FourthQuestion);

                        _ContentBoxFourthSet1 = questions.GetInfo()[q4].GetA1();
                        _ContentBoxFourthSet2 = questions.GetInfo()[q4].GetA2();
                        _ContentBoxFourthSet3 = questions.GetInfo()[q4].GetA3();


                        NotifyOfPropertyChange(() => ContentBoxFourthSet1);
                        NotifyOfPropertyChange(() => ContentBoxFourthSet2);
                        NotifyOfPropertyChange(() => ContentBoxFourthSet3);

                        //Load Fifth Set
                        _FifthQuestion = questions.GetInfo()[q5].GetQuestion();
                        NotifyOfPropertyChange(() => FifthQuestion);

                        _ContentBoxFifthSet1 = questions.GetInfo()[q5].GetA1();
                        _ContentBoxFifthSet2 = questions.GetInfo()[q5].GetA2();
                        _ContentBoxFifthSet3 = questions.GetInfo()[q5].GetA3();


                        NotifyOfPropertyChange(() => ContentBoxFifthSet1);
                        NotifyOfPropertyChange(() => ContentBoxFifthSet2);
                        NotifyOfPropertyChange(() => ContentBoxFifthSet3);

                        //

                }

                public void CalculateRandomQuestions()
                {
                        q1 = (uint)randomNumber.Next(1, 30);
                        if (q1 >= 1 && q1 <= 10)
                                dificultTest--;
                        else if (q1 >= 21 && q1 <= 30)
                                dificultTest++;
                        q2 = (uint)randomNumber.Next(1, 30);
                        while (q2 == q1)//zero colision
                        {
                                q2 = (uint)randomNumber.Next(1, 30);
                        }
                        if (q2 >= 1 && q2 <= 10)
                                dificultTest--;
                        else if (q1 >= 21 && q1 <= 30)
                                dificultTest++;

                        q3 = (uint)randomNumber.Next(1, 30);
                        while (q3 == q1 || q3 == q2)//zero colision
                        {
                                q3 = (uint)randomNumber.Next(1, 30);
                        }
                        if (q3 >= 1 && q3 <= 10)
                                dificultTest--;
                        else if (q1 >= 21 && q1 <= 30)
                                dificultTest++;
                        q4 = (uint)randomNumber.Next(1, 30);
                        while (q4 == q1 || q4 == q2 || q4 == q3)//zero colision
                        {
                                q3 = (uint)randomNumber.Next(1, 30);
                        }
                        if (q4 >= 1 && q4 <= 10)
                                dificultTest--;
                        else if (q1 >= 21 && q1 <= 30)
                                dificultTest++;
                        q5 = (uint)randomNumber.Next(1, 30);
                        while (q5 == q1 || q5 == q2 || q5 == q3 || q5 == q4)//zero colision
                        {
                                q3 = (uint)randomNumber.Next(1, 30);
                        }
                        if (q5 >= 1 && q5 <= 10)
                                dificultTest--;
                        else if (q1 >= 21 && q1 <= 30)
                                dificultTest++;
                }
                public string FullName
                {
                        get
                        {
                                return _fullName;
                        }
                }

                public string DifficultTest
                {
                        get
                        {
                                return _DifficultTest;
                        }
                }
                //First row

                public string _FirstQuestion = "Intrebarea numarul 1";
                public string FirstQuestion
                {
                        get
                        {
                                return _FirstQuestion;
                        }
                }

                public bool _Checked_FirstSet1;
                public bool _Checked_FirstSet2;
                public bool _Checked_FirstSet3;
                public bool CheckBoxFirstSet1
                {
                        get
                        {
                                return _Checked_FirstSet1;
                        }
                        set
                        {
                                _Checked_FirstSet1 = value;
                                if (!questions.GetInfo()[q1].CheckMultipleAnswer())
                                {
                                        if (_Checked_FirstSet1 == true && (_Checked_FirstSet2 == true || _Checked_FirstSet3 == true))
                                        {
                                                _Checked_FirstSet2 = false;
                                                _Checked_FirstSet3 = false;
                                                NotifyOfPropertyChange(() => CheckBoxFirstSet2);
                                                NotifyOfPropertyChange(() => CheckBoxFirstSet3);
                                        }
                                }
                                
                        }
                }
                public bool CheckBoxFirstSet2
                {
                        get
                        {
                                return _Checked_FirstSet2;
                        }
                        set
                        {
                                _Checked_FirstSet2 = value;
                                if (!questions.GetInfo()[q1].CheckMultipleAnswer())
                                {
                                        if (_Checked_FirstSet2 == true && (_Checked_FirstSet1 == true || _Checked_FirstSet3 == true))
                                        {
                                                _Checked_FirstSet1 = false;
                                                _Checked_FirstSet3 = false;
                                                NotifyOfPropertyChange(() => CheckBoxFirstSet1);
                                                NotifyOfPropertyChange(() => CheckBoxFirstSet3);
                                        }
                                }

                        }
                }
                public bool CheckBoxFirstSet3
                {
                        get
                        {
                                return _Checked_FirstSet3;
                        }
                        set
                        {
                                _Checked_FirstSet3 = value;
                                if (!questions.GetInfo()[q1].CheckMultipleAnswer())
                                {
                                        if (_Checked_FirstSet3 == true && (_Checked_FirstSet2 == true || _Checked_FirstSet1 == true))
                                        {
                                                _Checked_FirstSet1 = false;
                                                _Checked_FirstSet2 = false;
                                                NotifyOfPropertyChange(() => CheckBoxFirstSet2);
                                                NotifyOfPropertyChange(() => CheckBoxFirstSet1);
                                        }
                                }
                        }
                }

                public string _ContentBoxFirstSet1 = "Primul raspuns";
                public string _ContentBoxFirstSet2 = "Al 2-lea raspuns";
                public string _ContentBoxFirstSet3 = "Al 3-lea raspuns";
                public string ContentBoxFirstSet1
                {
                        get
                        {
                                return _ContentBoxFirstSet1;
                        }
                }

                public string ContentBoxFirstSet2
                {
                        get
                        {
                                return _ContentBoxFirstSet2;
                        }
                }
                public string ContentBoxFirstSet3
                {
                        get
                        {
                                return _ContentBoxFirstSet3;
                        }
                }

                //Second row

                public string _SecondQuestion = "Intrebarea numarul 2";
                public string SecondQuestion
                {
                        get
                        {
                                return _SecondQuestion;
                        }
                }

                public bool _Checked_SecondSet1;
                public bool _Checked_SecondSet2;
                public bool _Checked_SecondSet3;

                public bool CheckBoxSecondSet1
                {
                        get
                        {
                                return _Checked_SecondSet1;
                        }
                        set
                        {
                                _Checked_SecondSet1 = value;
                                if (!questions.GetInfo()[q2].CheckMultipleAnswer())
                                {
                                        
                                        if (_Checked_SecondSet1 == true && (_Checked_SecondSet2 == true || _Checked_SecondSet3 == true))
                                        {
                                                _Checked_SecondSet2 = false;
                                                _Checked_SecondSet3 = false;
                                                NotifyOfPropertyChange(() => CheckBoxSecondSet2);
                                                NotifyOfPropertyChange(() => CheckBoxSecondSet3);
                                        }
                                }
                        }
                }
                public bool CheckBoxSecondSet2
                {
                        get
                        {
                                return _Checked_SecondSet2;
                        }
                        set
                        {
                                _Checked_SecondSet2 = value;
                                if (!questions.GetInfo()[q2].CheckMultipleAnswer())
                                {

                                        if (_Checked_SecondSet2 == true && (_Checked_SecondSet1 == true || _Checked_SecondSet3 == true))
                                        {
                                                _Checked_SecondSet1 = false;
                                                _Checked_SecondSet3 = false;
                                                NotifyOfPropertyChange(() => CheckBoxSecondSet1);
                                                NotifyOfPropertyChange(() => CheckBoxSecondSet3);
                                        }
                                }
                        }
                }
                public bool CheckBoxSecondSet3
                {
                        get
                        {
                                return _Checked_SecondSet3;
                        }
                        set
                        {
                                _Checked_SecondSet3 = value;
                                if (!questions.GetInfo()[q2].CheckMultipleAnswer())
                                {

                                        if (_Checked_SecondSet3 == true && (_Checked_SecondSet2 == true || _Checked_SecondSet1 == true))
                                        {
                                                _Checked_SecondSet2 = false;
                                                _Checked_SecondSet1 = false;
                                                NotifyOfPropertyChange(() => CheckBoxSecondSet2);
                                                NotifyOfPropertyChange(() => CheckBoxSecondSet1);
                                        }
                                }
                        }
                }

                public string _ContentBoxSecondSet1 = "Primul raspuns";
                public string _ContentBoxSecondSet2 = "Al 2-lea raspuns";
                public string _ContentBoxSecondSet3 = "Al 3-lea raspuns";

                public string ContentBoxSecondSet1
                {
                        get
                        {
                                return _ContentBoxSecondSet1;
                        }
                }
                public string ContentBoxSecondSet2
                {
                        get
                        {
                                return _ContentBoxSecondSet2;
                        }
                }
                public string ContentBoxSecondSet3
                {
                        get
                        {
                                return _ContentBoxSecondSet3;
                        }
                }
                //third row
                public string _ThirdQuestion = "Intrebarea numarul 3";
                public string ThirdQuestion
                {
                        get
                        {
                                return _ThirdQuestion;
                        }
                }

                public bool _Checked_ThirdSet1;
                public bool _Checked_ThirdSet2;
                public bool _Checked_ThirdSet3;

                public bool CheckBoxThirdSet1
                {
                        get
                        {
                                return _Checked_ThirdSet1;
                        }
                        set
                        {
                                _Checked_ThirdSet1 = value;
                                if (!questions.GetInfo()[q3].CheckMultipleAnswer())
                                {

                                        if (_Checked_ThirdSet1 == true && (_Checked_ThirdSet2 == true || _Checked_ThirdSet3 == true))
                                        {
                                                _Checked_ThirdSet2 = false;
                                                _Checked_ThirdSet3 = false;
                                                NotifyOfPropertyChange(() => CheckBoxThirdSet2);
                                                NotifyOfPropertyChange(() => CheckBoxThirdSet3);
                                        }
                                }
                        }
                }

                public bool CheckBoxThirdSet2
                {
                        get
                        {
                                return _Checked_ThirdSet2;
                        }
                        set
                        {
                                _Checked_ThirdSet2 = value;
                                if (!questions.GetInfo()[q3].CheckMultipleAnswer())
                                {

                                        if (_Checked_ThirdSet2 == true && (_Checked_ThirdSet1 == true || _Checked_ThirdSet3 == true))
                                        {
                                                _Checked_ThirdSet1 = false;
                                                _Checked_ThirdSet3 = false;
                                                NotifyOfPropertyChange(() => CheckBoxThirdSet1);
                                                NotifyOfPropertyChange(() => CheckBoxThirdSet3);
                                        }
                                }
                        }
                }

                public bool CheckBoxThirdSet3
                {
                        get
                        {
                                return _Checked_ThirdSet3;
                        }
                        set
                        {
                                _Checked_ThirdSet3 = value;
                                if (!questions.GetInfo()[q3].CheckMultipleAnswer())
                                {

                                        if (_Checked_ThirdSet3 == true && (_Checked_ThirdSet2 == true || _Checked_ThirdSet1 == true))
                                        {
                                                _Checked_ThirdSet2 = false;
                                                _Checked_ThirdSet1 = false;
                                                NotifyOfPropertyChange(() => CheckBoxThirdSet1);
                                                NotifyOfPropertyChange(() => CheckBoxThirdSet2);
                                        }
                                }
                        }
                }

                public string _ContentBoxThirdSet1 = "Primul raspuns";
                public string _ContentBoxThirdSet2 = "Al 2-lea raspuns";
                public string _ContentBoxThirdSet3 = "Al 3-lea raspuns";

                public string ContentBoxThirdSet1
                {
                        get
                        {
                                return _ContentBoxThirdSet1;
                        }
                }
                public string ContentBoxThirdSet2
                {
                        get
                        {
                                return _ContentBoxThirdSet2;
                        }
                }
                public string ContentBoxThirdSet3
                {
                        get
                        {
                                return _ContentBoxThirdSet3;
                        }
                }

                //fourth row
                public string _FourthQuestion = "Intrebarea numarul 4";
                public string FourthQuestion
                {
                        get
                        {
                                return _FourthQuestion;
                        }
                }

                public bool _Checked_FourthSet1;
                public bool _Checked_FourthSet2;
                public bool _Checked_FourthSet3;

                public bool CheckBoxFourthSet1
                {
                        get
                        {
                                return _Checked_FourthSet1;
                        }
                        set
                        {
                                _Checked_FourthSet1 = value;
                                if (!questions.GetInfo()[q4].CheckMultipleAnswer())
                                {

                                        if (_Checked_FourthSet1 == true && (_Checked_FourthSet2 == true || _Checked_FourthSet3 == true))
                                        {
                                                _Checked_FourthSet2 = false;
                                                _Checked_FourthSet3 = false;
                                                NotifyOfPropertyChange(() => CheckBoxFourthSet2);
                                                NotifyOfPropertyChange(() => CheckBoxFourthSet3);
                                        }
                                }
                        }
                }
                public bool CheckBoxFourthSet2
                {
                        get
                        {
                                return _Checked_FourthSet2;
                        }
                        set
                        {
                                _Checked_FourthSet2 = value;
                                if (!questions.GetInfo()[q4].CheckMultipleAnswer())
                                {

                                        if (_Checked_FourthSet2 == true && (_Checked_FourthSet1 == true || _Checked_FourthSet3 == true))
                                        {
                                                _Checked_FourthSet1 = false;
                                                _Checked_FourthSet3 = false;
                                                NotifyOfPropertyChange(() => CheckBoxFourthSet1);
                                                NotifyOfPropertyChange(() => CheckBoxFourthSet3);
                                        }
                                }
                        }
                }
                public bool CheckBoxFourthSet3
                {
                        get
                        {
                                return _Checked_FourthSet3;
                        }
                        set
                        {
                                _Checked_FourthSet3 = value;
                                if (!questions.GetInfo()[q4].CheckMultipleAnswer())
                                {

                                        if (_Checked_FourthSet3 == true && (_Checked_FourthSet2 == true || _Checked_FourthSet1 == true))
                                        {
                                                _Checked_FourthSet2 = false;
                                                _Checked_FourthSet1 = false;
                                                NotifyOfPropertyChange(() => CheckBoxFourthSet2);
                                                NotifyOfPropertyChange(() => CheckBoxFourthSet1);
                                        }
                                }
                        }
                }

                public string _ContentBoxFourthSet1 = "Primul raspuns";
                public string _ContentBoxFourthSet2 = "Al 2-lea raspuns";
                public string _ContentBoxFourthSet3 = "Al 3-lea raspuns";

                public string ContentBoxFourthSet1
                {
                        get
                        {
                                return _ContentBoxFourthSet1;
                        }
                }
                public string ContentBoxFourthSet2
                {
                        get
                        {
                                return _ContentBoxFourthSet2;
                        }
                }
                public string ContentBoxFourthSet3
                {
                        get
                        {
                                return _ContentBoxFourthSet3;
                        }
                }
                //fifth row FifthQuestion
                //fourth row
                public string _FifthQuestion = "Intrebarea numarul 5";
                public string FifthQuestion
                {
                        get
                        {
                                return _FifthQuestion;
                        }
                }

                public bool _Checked_FifthSet1;
                public bool _Checked_FifthSet2;
                public bool _Checked_FifthSet3;

                public bool CheckBoxFifthSet1
                {
                        get
                        {
                                return _Checked_FifthSet1;
                        }
                        set
                        {
                                _Checked_FifthSet1 = value;
                                if (!questions.GetInfo()[q5].CheckMultipleAnswer())
                                {

                                        if (_Checked_FifthSet1 == true && (_Checked_FifthSet2 == true || _Checked_FifthSet3 == true))
                                        {
                                                _Checked_FifthSet2 = false;
                                                _Checked_FifthSet3 = false;
                                                NotifyOfPropertyChange(() => CheckBoxFifthSet2);
                                                NotifyOfPropertyChange(() => CheckBoxFifthSet3);
                                        }
                                }
                        }
                }
                public bool CheckBoxFifthSet2
                {
                        get
                        {
                                return _Checked_FifthSet2;
                        }
                        set
                        {
                                _Checked_FifthSet2 = value;
                                if (!questions.GetInfo()[q5].CheckMultipleAnswer())
                                {

                                        if (_Checked_FifthSet2 == true && (_Checked_FifthSet1 == true || _Checked_FifthSet3 == true))
                                        {
                                                _Checked_FifthSet1 = false;
                                                _Checked_FifthSet3 = false;
                                                NotifyOfPropertyChange(() => CheckBoxFifthSet1);
                                                NotifyOfPropertyChange(() => CheckBoxFifthSet3);
                                        }
                                }
                        }
                }
                public bool CheckBoxFifthSet3
                {
                        get
                        {
                                return _Checked_FifthSet3;
                        }
                        set
                        {
                                _Checked_FifthSet3 = value;
                                if (!questions.GetInfo()[q5].CheckMultipleAnswer())
                                {

                                        if (_Checked_FifthSet3 == true && (_Checked_FifthSet2 == true || _Checked_FifthSet1 == true))
                                        {
                                                _Checked_FifthSet2 = false;
                                                _Checked_FifthSet1 = false;
                                                NotifyOfPropertyChange(() => CheckBoxFifthSet2);
                                                NotifyOfPropertyChange(() => CheckBoxFifthSet1);
                                        }
                                }
                        }
                }

                public string _ContentBoxFifthSet1 = "Primul raspuns";
                public string _ContentBoxFifthSet2 = "Al 2-lea raspuns";
                public string _ContentBoxFifthSet3 = "Al 3-lea raspuns";

                public string ContentBoxFifthSet1
                {
                        get
                        {
                                return _ContentBoxFifthSet1;
                        }
                }
                public string ContentBoxFifthSet2
                {
                        get
                        {
                                return _ContentBoxFifthSet2;
                        }
                }
                public string ContentBoxFifthSet3
                {
                        get
                        {
                                return _ContentBoxFifthSet3;
                        }
                }

                //Button finish
                public void ButtonPress()
                {
                        //TryClose();
                        //MessageBox.Show($"{questions.Test()[1].GetQuestion()} : {questions.Test()[1].GetA1()} : {questions.Test()[1].GetA2()} : {questions.Test()[1].GetA3()}");
                        if(CheckAllBoxSellected())
                        {
                                MessageBox.Show("Termina de bifat intrebarile!");
                        }
                        else
                        {
                                IWindowManager obj = new WindowManager();
                                obj.ShowWindow(new ThirdViewModel($"Felicitari {_fullName}, ai reusit sa obtii {CalculateAnswers()}/5 puncte. Testul a avut: {_DifficultTest}."), null);
                                TryClose();
                        }

                }
                bool CheckAllBoxSellected()
                {
                        if (_Checked_FirstSet1 == false && _Checked_FirstSet2 == false && _Checked_FirstSet3 == false)
                        {
                                return true;
                        }
                        if (_Checked_SecondSet1 == false && _Checked_SecondSet2 == false && _Checked_SecondSet3 == false)
                        {
                                return true;
                        }
                        if (_Checked_ThirdSet1 == false && _Checked_ThirdSet2 == false && _Checked_ThirdSet3 == false)
                        {
                                return true;
                        }
                        if (_Checked_FourthSet1 == false && _Checked_FourthSet2 == false && _Checked_FourthSet3 == false)
                        {
                                return true;
                        }
                        if (_Checked_FifthSet1 == false && _Checked_FifthSet2 == false && _Checked_FifthSet3 == false)
                        {
                                return true;
                        }
                        return false;    
                }
                int CalculateAnswers()
                {
                        int result = 0, doubleAnswer = 0, tripleAnswer = 0;
                        //First question
                        if(!questions.GetInfo()[q1].CheckMultipleAnswer())
                        {
                                //checkbox 1
                                if (_Checked_FirstSet1 && questions.GetInfo()[q1].GetA1() == questions.GetInfo()[q1].GetRA1())
                                        result++;
                                //checkbox 2
                                if (_Checked_FirstSet2 && questions.GetInfo()[q1].GetA2() == questions.GetInfo()[q1].GetRA1())
                                        result++;
                                //checkbox 3
                                if (_Checked_FirstSet3 && questions.GetInfo()[q1].GetA3() == questions.GetInfo()[q1].GetRA1())
                                        result++;
                        }
                        else
                        {
                                //check 2 answers

                                if (questions.GetInfo()[q1].GetRA3() == "")
                                {
                                        //first checkbox
                                        if (_Checked_FirstSet1 && (questions.GetInfo()[q1].GetA1() == questions.GetInfo()[q1].GetRA1() || questions.GetInfo()[q1].GetA1() == questions.GetInfo()[q1].GetRA2()))
                                                doubleAnswer++;
                                        //second checkbox
                                        if (_Checked_FirstSet2 && (questions.GetInfo()[q1].GetA2() == questions.GetInfo()[q1].GetRA1() || questions.GetInfo()[q1].GetA2() == questions.GetInfo()[q1].GetRA2()))
                                                doubleAnswer++;
                                        //third checkbox
                                        if (_Checked_FirstSet3 && (questions.GetInfo()[q1].GetA3() == questions.GetInfo()[q1].GetRA1() || questions.GetInfo()[q1].GetA3() == questions.GetInfo()[q1].GetRA2()))
                                                doubleAnswer++;

                                        if (_Checked_FirstSet1 == _Checked_FirstSet2 == _Checked_FirstSet3 == true)//Check if all case is selected
                                                doubleAnswer = 0;

                                        if (doubleAnswer == 2) result++;
                                        doubleAnswer = 0;
                                }
                                else //check 3 answers
                                {
                                        if (_Checked_FirstSet1 && (questions.GetInfo()[q1].GetA1() == questions.GetInfo()[q1].GetRA1() || questions.GetInfo()[q1].GetA1() == questions.GetInfo()[q1].GetRA2() || questions.GetInfo()[q1].GetA1() == questions.GetInfo()[q1].GetRA3()))
                                                tripleAnswer++;

                                        if (_Checked_FirstSet2 && (questions.GetInfo()[q1].GetA2() == questions.GetInfo()[q1].GetRA1() || questions.GetInfo()[q1].GetA2() == questions.GetInfo()[q1].GetRA2() || questions.GetInfo()[q1].GetA2() == questions.GetInfo()[q1].GetRA3()))
                                                tripleAnswer++;

                                        if (_Checked_FirstSet3 && (questions.GetInfo()[q1].GetA3() == questions.GetInfo()[q1].GetRA1() || questions.GetInfo()[q1].GetA3() == questions.GetInfo()[q1].GetRA2() || questions.GetInfo()[q1].GetA3() == questions.GetInfo()[q1].GetRA3()))
                                                tripleAnswer++;

                                        if (tripleAnswer == 3) result++;
                                        tripleAnswer = 0;
                                }
                        }
                        //Second question
                        if (!questions.GetInfo()[q2].CheckMultipleAnswer())
                        {
                                //checkbox 1
                                if (_Checked_SecondSet1 && questions.GetInfo()[q2].GetA1() == questions.GetInfo()[q2].GetRA1())
                                        result++;

                                //checkbox 2
                                if (_Checked_SecondSet2 && questions.GetInfo()[q2].GetA2() == questions.GetInfo()[q2].GetRA1())
                                        result++;
                                //checkbox 3
                                if (_Checked_SecondSet3 && questions.GetInfo()[q2].GetA3() == questions.GetInfo()[q2].GetRA1())
                                        result++;
                        }
                        else
                        {
                                //check 2 answers
                                if (questions.GetInfo()[q2].GetRA3() == "")
                                {
                                        //first checkbox
                                        if (_Checked_SecondSet1 && (questions.GetInfo()[q2].GetA1() == questions.GetInfo()[q2].GetRA1() || questions.GetInfo()[q2].GetA1() == questions.GetInfo()[q2].GetRA2()))
                                                doubleAnswer++;
                                        //second checkbox
                                        if (_Checked_SecondSet2 && (questions.GetInfo()[q2].GetA2() == questions.GetInfo()[q2].GetRA1() || questions.GetInfo()[q2].GetA2() == questions.GetInfo()[q2].GetRA2()))
                                                doubleAnswer++;
                                        //third checkbox
                                        if (_Checked_SecondSet3 && (questions.GetInfo()[q2].GetA3() == questions.GetInfo()[q2].GetRA1() || questions.GetInfo()[q2].GetA3() == questions.GetInfo()[q2].GetRA2()))
                                                doubleAnswer++;

                                        if (_Checked_SecondSet1 == _Checked_SecondSet2 == _Checked_SecondSet3 == true)//Check if all case is selected
                                                doubleAnswer = 0;

                                        if (doubleAnswer == 2) result++;
                                        doubleAnswer = 0;
                                }
                                else //check 3 answers
                                {
                                        if (_Checked_SecondSet1 && (questions.GetInfo()[q2].GetA1() == questions.GetInfo()[q2].GetRA1() || questions.GetInfo()[q2].GetA1() == questions.GetInfo()[q2].GetRA2() || questions.GetInfo()[q2].GetA1() == questions.GetInfo()[q2].GetRA3()))
                                                tripleAnswer++;

                                        if (_Checked_SecondSet2 && (questions.GetInfo()[q2].GetA2() == questions.GetInfo()[q2].GetRA1() || questions.GetInfo()[q2].GetA2() == questions.GetInfo()[q2].GetRA2() || questions.GetInfo()[q2].GetA2() == questions.GetInfo()[q2].GetRA3()))
                                                tripleAnswer++;

                                        if (_Checked_SecondSet3 && (questions.GetInfo()[q2].GetA3() == questions.GetInfo()[q2].GetRA1() || questions.GetInfo()[q2].GetA3() == questions.GetInfo()[q2].GetRA2() || questions.GetInfo()[q2].GetA3() == questions.GetInfo()[q2].GetRA3()))
                                                tripleAnswer++;

                                        if (tripleAnswer == 3) result++;
                                        tripleAnswer = 0;
                                }
                        }
                        //third question
                        if (!questions.GetInfo()[q3].CheckMultipleAnswer())
                        {
                                //checkbox 1
                                if (_Checked_ThirdSet1 && questions.GetInfo()[q3].GetA1() == questions.GetInfo()[q3].GetRA1())
                                        result++;

                                //checkbox 2
                                if (_Checked_ThirdSet2 && questions.GetInfo()[q3].GetA2() == questions.GetInfo()[q3].GetRA1())
                                        result++;
                                //checkbox 3
                                if (_Checked_ThirdSet3 && questions.GetInfo()[q3].GetA3() == questions.GetInfo()[q3].GetRA1())
                                        result++;
                        }
                        else
                        {
                                //check 2 answers

                                if (questions.GetInfo()[q3].GetRA3() == "")
                                {

                                        //first checkbox
                                        if (_Checked_ThirdSet1 && (questions.GetInfo()[q3].GetA1() == questions.GetInfo()[q3].GetRA1() || questions.GetInfo()[q3].GetA1() == questions.GetInfo()[q3].GetRA2()))
                                                doubleAnswer++;
                                        //second checkbox
                                        if (_Checked_ThirdSet2 && (questions.GetInfo()[q3].GetA2() == questions.GetInfo()[q3].GetRA1() || questions.GetInfo()[q3].GetA2() == questions.GetInfo()[q3].GetRA2()))
                                                doubleAnswer++;
                                        //third checkbox
                                        if (_Checked_ThirdSet3 && (questions.GetInfo()[q3].GetA3() == questions.GetInfo()[q3].GetRA1() || questions.GetInfo()[q3].GetA3() == questions.GetInfo()[q3].GetRA2()))
                                                doubleAnswer++;

                                        if (_Checked_ThirdSet1 == _Checked_ThirdSet2 == _Checked_ThirdSet3 == true)//Check if all case is selected
                                                doubleAnswer = 0;

                                        if (doubleAnswer == 2) result++;
                                        doubleAnswer = 0;
                                }
                                else //check 3 answers
                                {
                                        if (_Checked_ThirdSet1 && (questions.GetInfo()[q3].GetA1() == questions.GetInfo()[q3].GetRA1() || questions.GetInfo()[q3].GetA1() == questions.GetInfo()[q3].GetRA2() || questions.GetInfo()[q3].GetA1() == questions.GetInfo()[q3].GetRA3()))
                                                tripleAnswer++;

                                        if (_Checked_ThirdSet2 && (questions.GetInfo()[q3].GetA2() == questions.GetInfo()[q3].GetRA1() || questions.GetInfo()[q3].GetA2() == questions.GetInfo()[q3].GetRA2() || questions.GetInfo()[q3].GetA2() == questions.GetInfo()[q3].GetRA3()))
                                                tripleAnswer++;

                                        if (_Checked_ThirdSet3 && (questions.GetInfo()[q3].GetA3() == questions.GetInfo()[q3].GetRA1() || questions.GetInfo()[q3].GetA3() == questions.GetInfo()[q3].GetRA2() || questions.GetInfo()[q3].GetA3() == questions.GetInfo()[q3].GetRA3()))
                                                tripleAnswer++;

                                        if (tripleAnswer == 3) result++;
                                        tripleAnswer = 0;
                                }
                        }
                        //fourth question
                        if (!questions.GetInfo()[q4].CheckMultipleAnswer())
                        {
                                //checkbox 1
                                if (_Checked_FourthSet1 && questions.GetInfo()[q4].GetA1() == questions.GetInfo()[q4].GetRA1())
                                        result++;

                                //checkbox 2
                                if (_Checked_FourthSet2 && questions.GetInfo()[q4].GetA2() == questions.GetInfo()[q4].GetRA1())
                                        result++;
                                //checkbox 3
                                if (_Checked_FourthSet3 && questions.GetInfo()[q4].GetA3() == questions.GetInfo()[q4].GetRA1())
                                        result++;
                        }
                        else
                        {
                                //check 2 answers

                                if (questions.GetInfo()[q4].GetRA3() == "")
                                {

                                        //first checkbox
                                        if (_Checked_FourthSet1 && (questions.GetInfo()[q4].GetA1() == questions.GetInfo()[q4].GetRA1() || questions.GetInfo()[q4].GetA1() == questions.GetInfo()[q4].GetRA2()))
                                                doubleAnswer++;
                                        //second checkbox
                                        if (_Checked_FourthSet2 && (questions.GetInfo()[q4].GetA2() == questions.GetInfo()[q4].GetRA1() || questions.GetInfo()[q4].GetA2() == questions.GetInfo()[q4].GetRA2()))
                                                doubleAnswer++;
                                        //third checkbox
                                        if (_Checked_FourthSet3 && (questions.GetInfo()[q4].GetA3() == questions.GetInfo()[q4].GetRA1() || questions.GetInfo()[q4].GetA3() == questions.GetInfo()[q4].GetRA2()))
                                                doubleAnswer++;

                                        if (_Checked_FourthSet1 == _Checked_FourthSet2 == _Checked_FourthSet3 == true)//Check if all case is selected
                                                doubleAnswer = 0;

                                        if (doubleAnswer == 2) result++;
                                        doubleAnswer = 0;
                                }
                                else //check 3 answers
                                {
                                        if (_Checked_FourthSet1 && (questions.GetInfo()[q4].GetA1() == questions.GetInfo()[q4].GetRA1() || questions.GetInfo()[q4].GetA1() == questions.GetInfo()[q4].GetRA2() || questions.GetInfo()[q4].GetA1() == questions.GetInfo()[q4].GetRA3()))
                                                tripleAnswer++;

                                        if (_Checked_FourthSet2 && (questions.GetInfo()[q4].GetA2() == questions.GetInfo()[q4].GetRA1() || questions.GetInfo()[q4].GetA2() == questions.GetInfo()[q4].GetRA2() || questions.GetInfo()[q4].GetA2() == questions.GetInfo()[q4].GetRA3()))
                                                tripleAnswer++;

                                        if (_Checked_FourthSet3 && (questions.GetInfo()[q4].GetA3() == questions.GetInfo()[q4].GetRA1() || questions.GetInfo()[q4].GetA3() == questions.GetInfo()[q4].GetRA2() || questions.GetInfo()[q4].GetA3() == questions.GetInfo()[q4].GetRA3()))
                                                tripleAnswer++;

                                        if (tripleAnswer == 3) result++;
                                        tripleAnswer = 0;
                                }
                        }
                        //fifth question
                        if (!questions.GetInfo()[q5].CheckMultipleAnswer())
                        {
                                //checkbox 1
                                if (_Checked_FifthSet1 && questions.GetInfo()[q5].GetA1() == questions.GetInfo()[q5].GetRA1())
                                        result++;

                                //checkbox 2
                                if (_Checked_FifthSet2 && questions.GetInfo()[q5].GetA2() == questions.GetInfo()[q5].GetRA1())
                                        result++;
                                //checkbox 3
                                if (_Checked_FifthSet3 && questions.GetInfo()[q5].GetA3() == questions.GetInfo()[q5].GetRA1())
                                        result++;
                        }
                        else
                        {
                                if (questions.GetInfo()[q5].GetRA3() == "")//check 2 answer
                                {

                                        //first checkbox
                                        if (_Checked_FifthSet1 && (questions.GetInfo()[q5].GetA1() == questions.GetInfo()[q5].GetRA1() || questions.GetInfo()[q5].GetA1() == questions.GetInfo()[q5].GetRA2()))
                                                doubleAnswer++;
                                        //second checkbox
                                        if (_Checked_FifthSet2 && (questions.GetInfo()[q5].GetA2() == questions.GetInfo()[q5].GetRA1() || questions.GetInfo()[q5].GetA2() == questions.GetInfo()[q5].GetRA2()))
                                                doubleAnswer++;
                                        //third checkbox
                                        if (_Checked_FifthSet3 && (questions.GetInfo()[q5].GetA3() == questions.GetInfo()[q5].GetRA1() || questions.GetInfo()[q5].GetA3() == questions.GetInfo()[q5].GetRA2()))
                                                doubleAnswer++;

                                        if (_Checked_FifthSet1 == _Checked_FifthSet2 == _Checked_FifthSet3 == true)//Check if all case is selected
                                                doubleAnswer = 0;

                                        if (doubleAnswer == 2) result++;
                                        doubleAnswer = 0;
                                }
                                else //check 3 answers
                                {
                                        if (_Checked_FifthSet1 && (questions.GetInfo()[q5].GetA1() == questions.GetInfo()[q5].GetRA1() || questions.GetInfo()[q5].GetA1() == questions.GetInfo()[q5].GetRA2() || questions.GetInfo()[q5].GetA1() == questions.GetInfo()[q5].GetRA3()))
                                                tripleAnswer++;

                                        if (_Checked_FifthSet2 && (questions.GetInfo()[q5].GetA2() == questions.GetInfo()[q5].GetRA1() || questions.GetInfo()[q5].GetA2() == questions.GetInfo()[q5].GetRA2() || questions.GetInfo()[q5].GetA2() == questions.GetInfo()[q5].GetRA3()))
                                                tripleAnswer++;

                                        if (_Checked_FifthSet3 && (questions.GetInfo()[q5].GetA3() == questions.GetInfo()[q5].GetRA1() || questions.GetInfo()[q5].GetA3() == questions.GetInfo()[q5].GetRA2() || questions.GetInfo()[q5].GetA3() == questions.GetInfo()[q5].GetRA3()))
                                                tripleAnswer++;

                                        if (tripleAnswer == 3) result++;
                                        tripleAnswer = 0;
                                }
                        }
                        return result;
                }
        }
}
