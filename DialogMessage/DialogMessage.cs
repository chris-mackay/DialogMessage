using System;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Policy;

namespace DialogMessage
{
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }

        private void DialogMessage_Load(object sender, EventArgs e)
        {
            // Once the ShowMessage function is called and the form appears
            // the code below makes the appropriate adjustments so the text appears properly

            // Gets the Y location of the bottom of MainInstruction
            int mainInstructionBottom = mainInstruction.Location.Y + mainInstruction.Height;

            // Gets the Y location of the bottom of Content
            int contentBottom = content.Location.Y + content.Height;

            // Offsets the top of Content from the bottom of MainInstruction
            int contentTop = mainInstructionBottom + 18; // 18 just looked nice to me

            // Sets new location of the top of Content
            content.Location = new Point(content.Location.X, contentTop);

            if (content.Text == string.Empty)

                // If only MainInstruction is provided then make the form a little shorter
                this.Height += (mainInstruction.Location.Y + mainInstruction.Height) - 50;
            else
                this.Height += (content.Location.Y + content.Height) - 60;
        }

        /// <summary>
        /// A public method with a return value of System.Windows.Forms.DialogResult
        /// </summary>
        /// <param name="_windowTitle"></param>
        /// <param name="_mainInstruction"></param>
        /// <param name="_msgButtons"></param>
        /// <param name="_content"></param> // Optional parameter with empty default value
        /// <returns></returns>
        public DialogResult ShowMessage(string _windowTitle,
                                        string _mainInstruction, 
                                        MsgButtons _msgButtons,
                                        string _content = "")
        {
            // Sets the initial height of the form
            Height = 157;

            // Sets Window Title
            Text = _windowTitle;

            // Sets MainInstruction
            mainInstruction.Text = _mainInstruction;

            // Sets Content
            content.Text = _content;

            // Sets the properties of the buttons based on which enum was provided
            switch (_msgButtons)
            {
                case MsgButtons.OK:

                    ConfigureOK();
                    break;

                case MsgButtons.OKCancel:

                    ConfigureOKCancel();
                    break;

                case MsgButtons.YesNo:

                    ConfigureYesNo();
                    break;

                default:
                    break;
            }

            // Shows the message to the user
            ShowDialog();

            return DialogResult; // Gets the result selected by the user
        }

        private void ConfigureOK()
        {
            // Button1 is the left button
            // Button2 is the right button

            Button1.Visible = false;
            Button2.DialogResult = DialogResult.OK;
            Button2.Text = "OK";
            AcceptButton = Button2; // The button that is clicked when the user presses the ENTER key. (OK)
            Button2.TabIndex = 0;
            ActiveControl = Button2;
        }

        private void ConfigureOKCancel()
        {
            // Button1 is the left button
            // Button2 is the right button

            Button1.DialogResult = DialogResult.OK;
            Button2.DialogResult = DialogResult.Cancel;
            Button1.Text = "OK";
            Button2.Text = "Cancel";
            AcceptButton = Button2; // The button that is clicked when the user presses the ENTER key. (Cancel)
            Button1.TabIndex = 1;
            Button2.TabIndex = 0;
            ActiveControl = Button2;
        }

        private void ConfigureYesNo()
        {
            // Button1 is the left button
            // Button2 is the right button

            Button1.DialogResult = DialogResult.Yes;
            Button2.DialogResult = DialogResult.No;
            Button1.Text = "Yes";
            Button2.Text = "No";
            AcceptButton = Button2; // The button that is clicked when the user presses the ENTER key. (No)
            Button1.TabIndex = 1;
            Button2.TabIndex = 0;
            ActiveControl = Button2;
        }

        // Message button enum for switch statement in ShowMessage
        // This will set the properties of the form buttons and their DialogResult
        public enum MsgButtons
        {
            OK = 0,
            OKCancel = 1,
            YesNo = 2
        }
    }
}
