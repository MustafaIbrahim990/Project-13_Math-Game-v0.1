using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game_Course_14
{
    public partial class frmStartPlayGameScreen : Form
    {
        enum enQuestionLevel { eEasy = 1, eMedium = 2, eHard = 3, eMix = 4 };

        enum enOperationType { eAdd = 1, eSubtract = 2, eMultiplication = 3, eDivide = 4, eMix = 5 };

        struct stQuestion
        {
            public enQuestionLevel QuestionLevel;
            public enOperationType OperationType;
            public int Number1;
            public int Number2;
            public int CorrectAnswer;
            public int PlayerAnswer;
            public bool IsPlayerAnswerCorrect;
            public short DurationTimeToSolveQuestion;
        }

        struct stQuiz
        {
            public stQuestion[] QuestionList;
            public enQuestionLevel QuestionLevel;
            public enOperationType OperationType;
            public short NumberOfQuestions;
            public short CurrentQuestion;
            public short NumberOfCorrectAnswer;
            public short NumberOfWrongAnswer;
            public bool IsPass;
        }

        stQuiz Quiz = new stQuiz();

        public static short NumberOfQuestions;
        public static string QuestionLevel;
        public static string OperationType;

        //-------------------------------------------------//

        Random random = new Random();
        private int RandomNumber(int From, int To)
        {
            return random.Next(From, To);
        }

        //-------------------------------------------------//

        private void ButtonFocus(Control control)
        {
            control.Focus();
        }

        private int GetNumber(enQuestionLevel QuestionLevel)
        {
            switch (QuestionLevel)
            {
                case enQuestionLevel.eEasy:
                    {
                        return RandomNumber(0, 10);
                    }
                case enQuestionLevel.eMedium:
                    {
                        return RandomNumber(10, 50);
                    }
                case enQuestionLevel.eHard:
                    {
                        return RandomNumber(50, 100);
                    }
                default:
                    {
                        return RandomNumber(0, 10);
                    }
            }
        }

        private enQuestionLevel GetRandomQuestionLevel()
        {
            return (enQuestionLevel)RandomNumber(1, 3);
        }

        private enOperationType GetRandomOperationType()
        {
            return (enOperationType)RandomNumber(1, 4);
        }

        private enQuestionLevel GetQuestionLevel(string QuestionLevel)
        {
            QuestionLevel = QuestionLevel.ToLower();

            switch (QuestionLevel)
            {
                case "easy":
                    {
                        return enQuestionLevel.eEasy;
                    }
                case "medium":
                    {
                        return enQuestionLevel.eMedium;
                    }
                case "hard":
                    {
                        return enQuestionLevel.eHard;
                    }
                case "mix":
                    {
                        return enQuestionLevel.eMix;
                    }
                default:
                    {
                        return enQuestionLevel.eEasy;
                    }
            }
        }

        private enOperationType GetOperationType(string OperationType)
        {
            OperationType = OperationType.ToLower();

            switch (OperationType)
            {
                case "add":
                    {
                        return enOperationType.eAdd;
                    }
                case "subtract":
                    {
                        return enOperationType.eSubtract;
                    }
                case "multiplication":
                    {
                        return enOperationType.eMultiplication;
                    }
                case "divide":
                    {
                        return enOperationType.eDivide;
                    }
                case "mix":
                    {
                        return enOperationType.eMix;
                    }
                default:
                    {
                        return enOperationType.eAdd;
                    }
            }
        }

        private char GetOperationTypeSymbol(enOperationType OperationType)
        {
            switch (OperationType)
            {
                case enOperationType.eAdd:
                    return '+';
                case enOperationType.eSubtract:
                    return '-';
                case enOperationType.eMultiplication:
                    return '×';
                case enOperationType.eDivide:
                    return '÷';
                default:
                    return '+';
            }
        }

        private short GetDurationTimeToSolveQuestion(enQuestionLevel QuestionLevel)
        {
            switch (QuestionLevel)
            {
                case enQuestionLevel.eEasy:
                    return 10;

                case enQuestionLevel.eMedium:
                    return 15;

                case enQuestionLevel.eHard:
                    return 20;

                default:
                    return 10;
            }
        }

        private int CalculateCorrectAnswer(int Number1, int Number2, enOperationType OperationType)
        {
            switch (OperationType)
            {
                case enOperationType.eAdd:
                    {
                        return Number1 + Number2;
                    }
                case enOperationType.eSubtract:
                    {
                        return Number1 - Number2;
                    }
                case enOperationType.eMultiplication:
                    {
                        return Number1 * Number2;
                    }
                case enOperationType.eDivide:
                    {
                        if (Number2 > Number1)
                            return 0;
                        else
                            return Number1 / Number2;
                    }
                default:
                    {
                        return Number1 + Number2;
                    }
            }
        }

        //-------------------------------------------------//

        private stQuestion FillQuestionInfo(enQuestionLevel QuestionLevel, enOperationType OperationType)
        {
            stQuestion Question = new stQuestion();

            Question.QuestionLevel = QuestionLevel;
            Question.OperationType = OperationType;

            Question.Number1 = GetNumber(Question.QuestionLevel);
            Question.Number2 = GetNumber(Question.QuestionLevel);
            Question.CorrectAnswer = CalculateCorrectAnswer(Question.Number1, Question.Number2, Question.OperationType);
            //
            Question.DurationTimeToSolveQuestion = GetDurationTimeToSolveQuestion(Question.QuestionLevel);
            return Question;
        }

        private stQuestion GenerateQuestion(enQuestionLevel QuestionLevel, enOperationType OperationType)
        {
            if (QuestionLevel == enQuestionLevel.eMix)
            {
                QuestionLevel = GetRandomQuestionLevel();
            }

            if (OperationType == enOperationType.eMix)
            {
                OperationType = GetRandomOperationType();
            }

            return FillQuestionInfo(QuestionLevel, OperationType);
        }

        private void GenerateQizeQuestions()
        {
            Quiz.NumberOfQuestions = NumberOfQuestions;
            Quiz.QuestionLevel = GetQuestionLevel(QuestionLevel);
            Quiz.OperationType = GetOperationType(OperationType);

            Quiz.QuestionList = new stQuestion[Quiz.NumberOfQuestions];

            for (short i = 0; i < Quiz.NumberOfQuestions; i++)
            {
                Quiz.QuestionList[i] = GenerateQuestion(Quiz.QuestionLevel, Quiz.OperationType);
            }
        }

        //-------------------------------------------------//

        public frmStartPlayGameScreen()
        {
            InitializeComponent();
        }

        private void frmStartPlayGameScreen_Load(object sender, EventArgs e)
        {
            DisabledButton(btnNextQuestion);
            ButtonFocus(txtPlayerAnswer);
            GenerateQizeQuestions();
            lblNumberOfQuestion.Text = Quiz.NumberOfQuestions.ToString();

            //
            StartTimer();

            Quiz.CurrentQuestion = 0;
            ShowQuizQuestionsInfo();
        }

        private void ShowQuizQuestionsInfo()
        {
            lblCurrentQuestion.Text = (Quiz.CurrentQuestion + 1).ToString();

            lblNumber1.Text = Quiz.QuestionList[Quiz.CurrentQuestion].Number1.ToString();
            lblNumber2.Text = Quiz.QuestionList[Quiz.CurrentQuestion].Number2.ToString();

            lblOpType.Text = GetOperationTypeSymbol(Quiz.QuestionList[Quiz.CurrentQuestion].OperationType).ToString();

            //
            lblTimer.Text = Quiz.QuestionList[Quiz.CurrentQuestion].DurationTimeToSolveQuestion.ToString();
        }

        //-------------------------------------------------//

        //Is Integer Number.
        private bool IsIntegerNumber(Control control)
        {
            int Number = 0;

            return int.TryParse(control.Text, out Number);
        }

        private void CheckIsIntegerNumber(object sender, CancelEventArgs e, Control control)
        {
            if (!IsIntegerNumber(control))
            {
                e.Cancel = true;
                ButtonFocus(control);

                errorProvider1.SetError(control, "Accept Only Numbers!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(control, "");
            }
        }

        private void ErrorProvider(object sender, CancelEventArgs e, Control control)
        {
            if (IsControlEmpty(control)) 
            {
                e.Cancel = true;
                ButtonFocus(control);

                errorProvider1.SetError(control, "Must have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(control, "");

                CheckIsIntegerNumber(sender, e, control);
            }
        }

        private void txtPlayerAnswer_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider(sender, e, txtPlayerAnswer);
        }

        //-------------------------------------------------//

        private void EnabledButton(Control control)
        {
            control.Enabled = true;
        }

        private void DisabledButton(Control control)
        {
            control.Enabled = false;
        }

        private bool IsButtonEnabled(Control control)
        {
            return control.Enabled;
        }

        private bool IsControlEmpty(Control control)
        {
            return string.IsNullOrWhiteSpace(control.Text);
        }

        private void CleartxtPlayerAnswer()
        {
            txtPlayerAnswer.Clear();
        }

        //

        private void CheckPlayerAnswer(int PlayerAnswer, int CorrectAnswer)
        {
            if (PlayerAnswer == CorrectAnswer)
                Quiz.QuestionList[Quiz.CurrentQuestion].IsPlayerAnswerCorrect = true;
            else
                Quiz.QuestionList[Quiz.CurrentQuestion].IsPlayerAnswerCorrect = false;
        }

        private void ShowPlayerAnswer(int CorrectAnswer)
        {
            if (Quiz.QuestionList[Quiz.CurrentQuestion].IsPlayerAnswerCorrect)
            {
                Quiz.NumberOfCorrectAnswer++;
                lblNumberOfCorrectAnswer.Text = Quiz.NumberOfCorrectAnswer.ToString();
                MessageBox.Show("Your Answer is Correct!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Quiz.NumberOfWrongAnswer++;
                lblNumberOfWrongAnswer.Text = Quiz.NumberOfWrongAnswer.ToString();
                MessageBox.Show($"Your Answer is Wrong!\nCoreect Answer is {CorrectAnswer}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsPlayerPass(short NumberOfCorrectAnswer, short NumberOfWrongAnswer)
        {
            return (NumberOfCorrectAnswer > NumberOfWrongAnswer);
        }

        private void CheckIsPlayerPass(short NumberOfCorrectAnswer, short NumberOfWrongAnswer)
        {
            Quiz.IsPass = IsPlayerPass(NumberOfCorrectAnswer, NumberOfWrongAnswer);
        }

        //-------------------------------------------------//

        private void ProcessToShowNextQuestion()
        {
            DisabledButton(txtPlayerAnswer);
            DisabledButton(btnCheckPlayerAnswer);
            EnabledButton(btnNextQuestion);
            ButtonFocus(btnNextQuestion);
        }

        private void ProcessToShowFinalResult()
        {
            DisabledButton(txtPlayerAnswer);
            DisabledButton(btnCheckPlayerAnswer);
            DisabledButton(btnNextQuestion);
        }

        private bool IsMathGamesOver()
        {
            return (Quiz.CurrentQuestion + 1 == Quiz.NumberOfQuestions);
        }

        private void CheckMathGamesOver()
        {
            if (!IsMathGamesOver())
                return;

            DisabledButton(txtPlayerAnswer);
            DisabledButton(btnCheckPlayerAnswer);
            DisabledButton(btnNextQuestion);

            CheckIsPlayerPass(Quiz.NumberOfCorrectAnswer, Quiz.NumberOfWrongAnswer);

            TransferFinalResultInfo();
            ShowFinalResultScrren();
        }

        private void btnCheckPlayerAnswer_Click(object sender, EventArgs e)
        {
            if (IsControlEmpty(txtPlayerAnswer) || !IsIntegerNumber(txtPlayerAnswer))
                return;

            StopTimer();

            Quiz.QuestionList[Quiz.CurrentQuestion].PlayerAnswer = Convert.ToInt32(txtPlayerAnswer.Text);

            CheckPlayerAnswer(Quiz.QuestionList[Quiz.CurrentQuestion].PlayerAnswer, Quiz.QuestionList[Quiz.CurrentQuestion].CorrectAnswer);
            ShowPlayerAnswer(Quiz.QuestionList[Quiz.CurrentQuestion].CorrectAnswer);

            DisabledButton(txtPlayerAnswer);
            DisabledButton(btnCheckPlayerAnswer);
            EnabledButton(btnNextQuestion);
            ButtonFocus(btnNextQuestion);

            CheckMathGamesOver();
        }

        //-------------------------------------------------//

        private string GetQuestionLevelName(enQuestionLevel QuestionLevel)
        {
            switch (QuestionLevel)
            {
                case enQuestionLevel.eEasy:
                    return "Easy";
                case enQuestionLevel.eMedium:
                    return "Medium";
                case enQuestionLevel.eHard:
                    return "Hard";
                case enQuestionLevel.eMix:
                    return "Mix";
                default:
                    return "Easy";
            }
        }

        private string GetOperationTypeName(enOperationType OperationType)
        {
            switch (OperationType)
            {
                case enOperationType.eAdd:
                    return "Add";
                case enOperationType.eSubtract:
                    return "Subtract";
                case enOperationType.eMultiplication:
                    return "Multiplication";
                case enOperationType.eDivide:
                    return "Divide";
                case enOperationType.eMix:
                    return "Mix";
                default:
                    return "Add";
            }
        }

        private string GetFinalResult(bool IsPass)
        {
            return (IsPass) ? "Pass" : "Fail";
        }

        private void TransferFinalResultInfo()
        {
            frmGameFinalResultScreen.GetFinalResultInfo(Quiz.NumberOfQuestions, GetQuestionLevelName(Quiz.QuestionLevel), GetOperationTypeName(Quiz.OperationType), Quiz.NumberOfCorrectAnswer, Quiz.NumberOfWrongAnswer, GetFinalResult(Quiz.IsPass));
        }

        private void ShowFinalResultScrren()
        {
            this.Close();
            Form frm = new frmGameFinalResultScreen();
            frm.ShowDialog();
        }

        //-------------------------------------------------//

        private void ShowNextQuestion()
        {
            if (IsButtonEnabled(txtPlayerAnswer) || IsButtonEnabled(btnCheckPlayerAnswer))
                return;

            CleartxtPlayerAnswer();
            EnabledButton(btnCheckPlayerAnswer);
            EnabledButton(txtPlayerAnswer);
            ButtonFocus(txtPlayerAnswer);
            DisabledButton(btnNextQuestion);

            Quiz.CurrentQuestion++;
            ShowQuizQuestionsInfo();
            StartTimer();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            ShowNextQuestion();
        }

        //-------------------------------------------------//

        private void btnClose_Click(object sender, EventArgs e)
        {
            StopTimer();
            this.Close();
        }

        //-------------------------------------------------//

        private void StartTimer()
        {
            timer1.Start();
        }

        private void StopTimer()
        {
            timer1.Stop();
        }

        private bool IsZero(short Number)
        {
            return Number == 0;
        }

        private bool IsTimeOver(short DurationToSolveQuestion)
        {
            return IsZero(DurationToSolveQuestion);
        }

        private void CheckIsTimeOver()
        {
            if (!IsTimeOver(Quiz.QuestionList[Quiz.CurrentQuestion].DurationTimeToSolveQuestion))
                return;

            StopTimer();
            MessageBox.Show("Time is Over", "Timer!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!IsMathGamesOver())
            {
                DisabledButton(txtPlayerAnswer);
                DisabledButton(btnCheckPlayerAnswer);
                EnabledButton(btnNextQuestion);
                ButtonFocus(btnNextQuestion);
                ShowNextQuestion();
            }
            CheckMathGamesOver();
        }

        private void CounterDecrease()
        {
            if (IsZero(Quiz.QuestionList[Quiz.CurrentQuestion].DurationTimeToSolveQuestion))
                return;

            Quiz.QuestionList[Quiz.CurrentQuestion].DurationTimeToSolveQuestion--;
        }

        private void ShowTimer()
        {
            lblTimer.Text = Quiz.QuestionList[Quiz.CurrentQuestion].DurationTimeToSolveQuestion.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CounterDecrease();
            ShowTimer();
            CheckIsTimeOver();
        }
    }
}