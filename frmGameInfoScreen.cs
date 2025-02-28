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
    public partial class frmGameInfoScreen : Form
    {
        short NumberOfQuestion;
        string QuestionLevel;
        string OperationType;

        //-------------------------------------------------//

        public frmGameInfoScreen()
        {
            InitializeComponent();
        }

        private void frmInfoGameScreen_Load(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------//

        private bool IsControlEmpty(Control control)
        {
            return string.IsNullOrWhiteSpace(control.Text);
        }

        private void ComboBoxErrorProvider(Control control, CancelEventArgs e)
        {
            if (IsControlEmpty(control)) 
            {
                e.Cancel = true;
                control.Focus();

                errorProvider1.SetError(control, "Must have a Value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(control, "");
            }
        }

        private void cbNumberOfQuestion_Validating(object sender, CancelEventArgs e)
        {
            ComboBoxErrorProvider(cbNumberOfQuestion, e);
        }

        private void cbQuestionLevel_Validating(object sender, CancelEventArgs e)
        {
            ComboBoxErrorProvider(cbQuestionLevel, e);
        }

        private void cbOperationType_Validating(object sender, CancelEventArgs e)
        {
            ComboBoxErrorProvider(cbOperationType, e);
        }

        //-------------------------------------------------//

        private bool IsReadyToOpenNextForm()
        {
            if (IsControlEmpty(cbNumberOfQuestion) || IsControlEmpty(cbQuestionLevel) || IsControlEmpty(cbOperationType))
                return false;
            else
                return true;
        }

        //-------------------------------------------------//

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!IsReadyToOpenNextForm())
                return;

            TransferQuestionsInfo();

            Form frm = new frmStartPlayGameScreen();
            frm.ShowDialog();
        }

        //-------------------------------------------------//

        private void GetQuestionInfo()
        {
            NumberOfQuestion = Convert.ToInt16(cbNumberOfQuestion.Text);
            QuestionLevel = cbQuestionLevel.Text;
            OperationType = cbOperationType.Text;
        }

        private void TransferQuestionsInfo()
        {
            GetQuestionInfo();
            frmStartPlayGameScreen.NumberOfQuestions = NumberOfQuestion;
            frmStartPlayGameScreen.QuestionLevel = QuestionLevel;
            frmStartPlayGameScreen.OperationType = OperationType;
        }

        //-------------------------------------------------//
    }
}