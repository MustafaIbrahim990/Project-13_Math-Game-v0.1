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
    public partial class frmGameFinalResultScreen : Form
    {
        //-------------------------------------------------//

        struct stFinalResultInfo
        {
            public short NumberOfQuestion;
            public string QuestionLevel;
            public string OperationType;
            public short NumberOfCorrectAnswer;
            public short NumberOfWrongAnswer;
            public string FinalResult;
        }

        static stFinalResultInfo FinalResultInfo = new stFinalResultInfo();

        //-------------------------------------------------//

        static public void GetFinalResultInfo(short NumberOfQuestion, string QuestionLevel, string OperationType, short NumberOfCorrectAnswer, short NumberOfWrongAnswer, string FinalResult)
        {
            FinalResultInfo.NumberOfQuestion = NumberOfQuestion;
            FinalResultInfo.QuestionLevel = QuestionLevel;
            FinalResultInfo.OperationType = OperationType;
            FinalResultInfo.NumberOfCorrectAnswer = NumberOfCorrectAnswer;
            FinalResultInfo.NumberOfWrongAnswer = NumberOfWrongAnswer;
            FinalResultInfo.FinalResult = FinalResult;
        }

        private void ShowFinalResult()
        {
            lblNumberOfQuestion.Text = FinalResultInfo.NumberOfQuestion.ToString();
            lblQuestionLevel.Text = FinalResultInfo.QuestionLevel;
            lblOperationType.Text = FinalResultInfo.OperationType;
            lblNumberOfCorrectAnswer.Text = FinalResultInfo.NumberOfCorrectAnswer.ToString();
            lblNumberOfWrongAnswer.Text = FinalResultInfo.NumberOfWrongAnswer.ToString();
            lblFInalResult.Text = FinalResultInfo.FinalResult;
        }

        //-------------------------------------------------//

        public frmGameFinalResultScreen()
        {
            InitializeComponent();
        }

        private void frmGameFinalResult_Load(object sender, EventArgs e)
        {
            ShowFinalResult();
        }

        //-------------------------------------------------//

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------------------------------------//
    }
}