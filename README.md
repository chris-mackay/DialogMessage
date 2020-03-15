# DialogMessage
A homemade messagebox for Windows

![Message](Message.png?raw=true "Message")

### Supports three button configurations in an `enum`
```csharp
// Message button enum for switch statement in ShowMessage
// This will set the properties of the form buttons and their DialogResult
public enum MsgButtons
{
    OK = 0,
    OKCancel = 1,
    YesNo = 2
}
```
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
