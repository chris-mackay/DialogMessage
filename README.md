# DialogMessage
A simple text only version of the Windows TaskDialog

![Message](Message.png?raw=true "Message")

# Implementation

```csharp
DialogMessage.Message message = new DialogMessage.Message();

if (message.ShowMessage(

    // Window Title
    "Window Title",

    // Main Instruction
    "This is the Main Instruction\n" +
    "This is another line\n" +
    "This is another line\n",

    // Dialog buttons
    DialogMessage.Message.MsgButtons.YesNo,

    // Content
    "This is the content\n" +
    "This is another line\n" +
    "This is another line\n")

    // Checks DialogResult of the button clicked by user
    == DialogResult.Yes) 

    // Show the Windows standard MessageBox to test result
    MessageBox.Show("You clicked Yes!");
else
    MessageBox.Show("You clicked No!");
```