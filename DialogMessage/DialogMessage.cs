using System.Windows.Forms;

namespace DialogMessage
{
    public static class DMessage
    {
        /// <summary>
        /// A public static method with a return value of System.Windows.Forms.DialogResult
        /// </summary>
        /// <param name="_windowTitle"></param>
        /// <param name="_mainInstruction"></param>
        /// <param name="_msgButtons"></param>
        /// <param name="_content"></param> // Optional parameter with empty default value
        /// <returns></returns>
        public static DialogResult ShowMessage(string _windowTitle,
                                               string _mainInstruction,
                                               MsgButtons _msgButtons,
                                               string _content = "")
        {
            // Creates a new instance of MainForm so we can set the properties of the controls
            MainForm main = new MainForm();

            // Sets the initial height of the form
            main.Height = 157;

            // Sets Window Title
            main.Text = _windowTitle;

            // Sets MainInstruction
            main.mainInstruction.Text = _mainInstruction;

            // Sets Content
            main.content.Text = _content;

            // Sets the properties of the buttons based on which enum was provided
            switch (_msgButtons)
            {
                // Button1 is the left button
                // Button2 is the right button

                case MsgButtons.OK:
                    
                    main.Button1.Visible = false;
                    main.Button2.DialogResult = DialogResult.OK;
                    main.Button2.Text = "OK";
                    main.AcceptButton = main.Button2; 
                    main.Button2.TabIndex = 0;
                    main.ActiveControl = main.Button2;

                    break;

                case MsgButtons.OKCancel:

                    main.Button1.DialogResult = DialogResult.OK;
                    main.Button2.DialogResult = DialogResult.Cancel;
                    main.Button1.Text = "OK";
                    main.Button2.Text = "Cancel";
                    main.AcceptButton = main.Button2; 
                    main.Button1.TabIndex = 1;
                    main.Button2.TabIndex = 0;
                    main.ActiveControl = main.Button2;

                    break;

                case MsgButtons.YesNo:

                    main.Button1.DialogResult = DialogResult.Yes;
                    main.Button2.DialogResult = DialogResult.No;
                    main.Button1.Text = "Yes";
                    main.Button2.Text = "No";
                    main.AcceptButton = main.Button2; 
                    main.Button1.TabIndex = 1;
                    main.Button2.TabIndex = 0;
                    main.ActiveControl = main.Button2;

                    break;

                default:
                    break;
            }

            // Shows the message and gets the result selected by the user
            return main.ShowDialog();
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
